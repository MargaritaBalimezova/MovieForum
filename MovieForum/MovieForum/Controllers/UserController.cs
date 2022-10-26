﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieForum.Services.DTOModels;
using MovieForum.Services.Interfaces;
using MovieForum.Web.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieForum.Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        private readonly IUserServices userService;

        public IWebHostEnvironment hostingEnvironment;

        public UserController( IUserServices userService, IWebHostEnvironment hostingEnvironment)
        {
            this.userService = userService;
            this.hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
        public  async Task<IActionResult> Update()
        {
            var user = await userService.GetUserByEmailAsync(this.User.Identity.Name);

            var update = new UpdateUserViewModel
            {
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                ImagePath = user.ImagePath.Split("Images\\").Last()
            };
            return this.View(update);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Update(UpdateUserViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                var user = await userService.GetUserByEmailAsync(this.User.Identity.Name);

                if (await userService.IsExistingAsync(model.Email) && model.Email != user.Email)
                {
                    this.ModelState.AddModelError("Email", "User with this email address already exists.");
                }

                var userDTO = new UpdateUserDTO();

                userDTO.Password = model.Password ?? user.Password;
                userDTO.FirstName = model.FirstName ?? user.FirstName;
                userDTO.LastName = model.LastName ?? user.LastName;
                userDTO.Email = model.Email ?? user.Email;
                if(model.File!= null)
                {
                    userDTO.ImagePath = UploadPhoto(model.File);
                }
                if (model.PhoneNumber != null)
                {
                    userDTO.PhoneNumber = model.PhoneNumber;
                }

                await userService.UpdateAsync(user.Id, userDTO);

            }
            catch (Exception)
            {
              return this.View(model);
            }


            return this.RedirectToAction("Index", "Home");
        }


        private string UploadPhoto(IFormFile file)
        {
            if (file == null)
            {
                return null;
            }
            FileInfo fi = new FileInfo(file.FileName);
            var newFileName = "Image_" + DateTime.Now.TimeOfDay.Milliseconds + fi.Extension;
            if (!Directory.Exists(hostingEnvironment.WebRootPath + "\\Images\\"))
            {
                Directory.CreateDirectory(hostingEnvironment.WebRootPath + "\\Images\\");
            }
            var path = Path.Combine("", hostingEnvironment.WebRootPath + "\\Images\\" + newFileName);
            using (FileStream stream = System.IO.File.Create(path))
            {
                file.CopyTo(stream);
                stream.Flush();
            }
            return path;
        }
    }
}