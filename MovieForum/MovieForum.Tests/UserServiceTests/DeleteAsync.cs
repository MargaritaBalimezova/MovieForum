using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieForum.Data;
using MovieForum.Services.Interfaces;
using MovieForum.Services.Services;
using MovieForum.Web.MappingConfig;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieForum.Tests.UserServiceTests
{
    [TestClass]
    public class DeleteAsync
    {
        private static IMapper _mapper;
        private MovieForumContext context;
        private readonly IEmailService emailService;
        private readonly IConfiguration configuration;
        public DeleteAsync()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MovieForumProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [TestInitialize]
        public void Init()
        {
            var options = new DbContextOptionsBuilder<MovieForumContext>()
                               .UseInMemoryDatabase(Guid.NewGuid().ToString())
                               .Options;

            MovieForumContext movieForumContext = new MovieForumContext(options);
            context = movieForumContext;
        }

        [TestMethod]
        public async Task DeleteAsync_Should_DeleteUserById()
        {
            await context.AddRangeAsync(Helper.Users);
            await context.SaveChangesAsync();

            int userId = 1;

            var service = new UserServices(emailService, configuration, context, _mapper);

            var expected = await service.GetUserDTOByIdAsync(userId);

            var actual = await service.DeleteAsync(expected.Email);

            Assert.AreEqual(expected.Username, actual.Username);
            Assert.IsTrue(await context.Users.AnyAsync(x => x.Id == actual.UserId 
                                                        && x.IsDeleted == true));
        }
    }
}
