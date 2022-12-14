using MovieForum.Data.Models;
using MovieForum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieForum.Tests
{
    public static class Helper
    {
        public static List<User> Users
        {
            get
            {
                return new List<User>()
                {
                    new User
                    {
                        Id = 1,
                        Username = "AngelMarinski",
                        FirstName = "Angel",
                        LastName = "Marinski",
                        Password = "12345678",
                        Email = "fakeemail@gmail.com",
                        RoleId = 2,
                        IsDeleted = false
                    },
                 new User
                 {
                     Id = 2,
                     Username = "Maggie",
                     FirstName = "Maggie",
                     LastName = "TheBoss",
                     Password = "12345678",
                     Email = "adminsemail@gmail.com",
                     RoleId = 1,
                     IsDeleted = false
                 },
                  new User
                  {
                      Id = 3,
                      Username = "Rado561",
                      FirstName = "Radoslav",
                      LastName = "Berov",
                      Password = "12345678",
                      Email = "morefakeemails@gmail.com",
                      RoleId = 1,
                      IsDeleted = false
                  },

                   new User
                    {
                        Id = 4,
                        Username = "BlockedUser",
                        FirstName = "Block",
                        LastName = "User",
                        Password = "12345678",
                        Email = "fakeeemail@gmail.com",
                        RoleId = 2,
                        IsDeleted = false,
                        IsBlocked = true
                        
                    },
                };
            }
        }

        public static List<Comment> Comments
        {
            get
            {
                return new List<Comment>()
                {
                    new Comment
                    {
                        Id = 1,
                        Content = "Pulna Boza",
                        AuthorId = 1,
                        MovieId = 1,
                        PostedOn = DateTime.Now,
                        IsDeleted = false,
                    },
                    new Comment
                    {
                        Id = 2,
                        Content = "unikalna produkciq siujeta e ubiec",
                        AuthorId = 3,
                        MovieId = 2,
                        PostedOn = DateTime.Now,
                        IsDeleted = false
                    }

                };
            }
        }

        public static List<Genre> Genres
        {
            get
            {
                return new List<Genre>()
                {
                    new Genre
                    {
                        Id = 1,
                        Name = "Comedy",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 2,
                        Name = "Sci-Fi",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 3,
                        Name = "Horror",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 4,
                        Name = "Romance",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 5,
                        Name = "Action",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 6,
                        Name = "Thriller",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 7,
                        Name = "Drama",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 8,
                        Name = "Mystery",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 9,
                        Name = "Crime",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 10,
                        Name = "Animation",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 11,
                        Name = "Adventure",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 12,
                        Name = "Fantasy",
                        IsDeleted = false
                    },
                    new Genre
                    {
                        Id = 13,
                        Name = "Superhero",
                        IsDeleted = false
                    }
                };
            }
        }

        public static List<Role> Roles
        {
            get
            {
                return new List<Role>()
                {
                    new Role
                    {
                        Id = 1,
                        Name = "Admin"
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "User"
                    }
                };
            }
        }

        public static List<Movie> Movies
        {
            get
            {
                return new List<Movie>()
                {
                     new Movie
                     {
                         Id = 1,
                         AuthorID = 1,
                         Title = "Top Gun the new one",
                         Content = "On of my favourite movies of all time",
                         GenreId = 5,
                         ReleaseDate = DateTime.Now,
                         Posted = DateTime.Today.AddDays(-1),
                     },
                     new Movie
                     {
                         Id = 2,
                         AuthorID = 2,
                         Title = "Spiderman: Far From Home",
                         Content = "The bes spiderman movie so far, I love Tom Holand",
                         GenreId = 13,
                         ReleaseDate = DateTime.Now,
                         Posted = DateTime.Today,
                     }
                };               
            }
        }

        public static List<Tag> Tags
        {
            get
            {
                return new List<Tag>()
                {
                    new Tag
                    {
                        Id = 1,
                        TagName = "drama",
                        IsDeleted = false
                    },
                    new Tag
                    {
                        Id = 2,
                        TagName = "action",

                        IsDeleted = false
                    },
                    new Tag
                    {
                        Id = 3,
                        TagName = "anime",

                        IsDeleted = true
                    }
                };
            }
        }

        public static List<Actor> Actors
        {
            get
            {
                return new List<Actor>()
                {
                     new Actor
                     {
                         Id=1,
                         FirstName = "Tom",
                         LastName = "Cruize",
                         IsDeleted = false,
                     },
                     new Actor
                     {
                         Id=2,
                         FirstName = "Tom",
                         LastName = "Holand",
                         IsDeleted = false,

                     }
                };
            }
        }

        public static List<MovieActor> MovieActors
        {
            get
            {
                return new List<MovieActor>()
                {
                    new MovieActor
                    {
                        MovieId = 1,
                        ActorId = 1,
                        IsDeleted = false,
                    },
                    new MovieActor
                    {

                        MovieId = 1,
                        ActorId = 2,
                        IsDeleted = false,
                    }
                };
            }
        }

        public static List<MovieTags> MovieTags
        {
            get
            {
                return new List<MovieTags>()
                {
                    new MovieTags
                    {
                        MovieId = 1,
                        TagId = 2,
                        IsDeleted = false
                    },
                    new MovieTags
                    {
                        MovieId = 2,
                        TagId = 1,
                        IsDeleted = false
                    }
                };
            }
        }

        public static List<Rating> Ratings
        {
            get
            {
                return new List<Rating>()
                {
                    new Rating
                    {
                        Id = 1,
                        UserID = 1,
                        MovieId = 2,
                        Rate = 5,
                        IsDeleted = false
                    },
                    new Rating
                    {
                        Id=2,
                        UserID = 2,
                        MovieId = 2,
                        Rate = 7,
                        IsDeleted = false
                    },
                    new Rating
                    {
                        Id=3,
                        UserID = 2,
                        MovieId = 1,
                        Rate = 7,
                        IsDeleted = false
                    }
                    ,new Rating
                    {
                        Id=4,
                        UserID = 1,
                        MovieId = 1,
                        Rate = 10,
                        IsDeleted = false
                    }
                };
            }
        }
    }
}
