﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieForum.Data;

namespace MovieForum.Data.Migrations
{
    [DbContext(typeof(MovieForumContext))]
    partial class MovieForumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieForum.Data.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Tom",
                            IsDeleted = false,
                            LastName = "Cruize"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Tom",
                            IsDeleted = false,
                            LastName = "Holand"
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisLikesCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LikesCount")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("PostedOn")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Comments");

                    b.HasCheckConstraint("CK_Comments_Content", "(LEN(Content)) >= 10");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Content = "Pulna Boza",
                            DisLikesCount = 0,
                            IsDeleted = false,
                            LikesCount = 0,
                            MovieId = 1,
                            PostedOn = new DateTime(2022, 10, 28, 13, 53, 55, 98, DateTimeKind.Local).AddTicks(2659)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 3,
                            Content = "unikalna produkciq siujeta e ubiec",
                            DisLikesCount = 0,
                            IsDeleted = false,
                            LikesCount = 0,
                            MovieId = 2,
                            PostedOn = new DateTime(2022, 10, 28, 13, 53, 55, 100, DateTimeKind.Local).AddTicks(8139)
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Sci-Fi"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 8,
                            IsDeleted = false,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 9,
                            IsDeleted = false,
                            Name = "Crime"
                        },
                        new
                        {
                            Id = 10,
                            IsDeleted = false,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 11,
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 12,
                            IsDeleted = false,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 13,
                            IsDeleted = false,
                            Name = "Superhero"
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.MovieActor", b =>
                {
                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("ActorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ActorId = 1,
                            IsDeleted = false
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 2,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.MovieTags", b =>
                {
                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("MovieId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("MoviesTags");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            TagId = 2,
                            IsDeleted = false
                        },
                        new
                        {
                            MovieId = 2,
                            TagId = 1,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Rating");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            MovieId = 2,
                            Rate = 5,
                            UserID = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            MovieId = 2,
                            Rate = 7,
                            UserID = 2
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.Reaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disliked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("Liked")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("LikesDislikes");
                });

            modelBuilder.Entity("MovieForum.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasCheckConstraint("CK_Tags_TagName", "(LEN(TagName))>= 2");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            TagName = "drama"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            TagName = "action"
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasCheckConstraint("CK_Users_Username", "(LEN(Username))>= 4");

                    b.HasCheckConstraint("CK_Users_FirstName", "(LEN(FirstName))>= 4");

                    b.HasCheckConstraint("CK_Users_LastName", "(LEN(LastName))>= 4");

                    b.HasCheckConstraint("CK_Users_Password", "(LEN(Password))>= 8");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "fakeemail@gmail.com",
                            FirstName = "Angel",
                            ImagePath = "Images/Image_500.jpg",
                            IsBlocked = false,
                            IsDeleted = false,
                            LastName = "Marinski",
                            Password = "AQAAAAEAACcQAAAAEN5vZcJ1fRhWV9IRPjpExVoLQ+rK93UdXcygHMC5O/23r9VnUygmZFAi4pPjM8z3MA==",
                            RoleId = 2,
                            Username = "AngelMarinski"
                        },
                        new
                        {
                            Id = 2,
                            Email = "adminsemail@gmail.com",
                            FirstName = "Maggie",
                            ImagePath = "Images/Image_500.jpg",
                            IsBlocked = false,
                            IsDeleted = false,
                            LastName = "TheBoss",
                            Password = "AQAAAAEAACcQAAAAECI28iQIJufP3Kn6hT90n87hw+r774rkIgLfXIRPigBLakUDwVT3kWHlb3rPpLEPDA==",
                            RoleId = 1,
                            Username = "Maggie"
                        },
                        new
                        {
                            Id = 3,
                            Email = "morefakeemails@gmail.com",
                            FirstName = "Radoslav",
                            ImagePath = "Images/Image_500.jpg",
                            IsBlocked = false,
                            IsDeleted = false,
                            LastName = "Berov",
                            Password = "AQAAAAEAACcQAAAAEBjQvP356RT+khWuIxR+HYGs9zv58caUixUDseCGyRX8czMndmEErSVo6EQ1HIXlLg==",
                            RoleId = 1,
                            Username = "Rado561"
                        });
                });

            modelBuilder.Entity("MovieForum.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Posted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorID");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasCheckConstraint("CK_Movies_Title", "(LEN(Title))>= 2");

                    b.HasCheckConstraint("CK_Movies_Content", "(LEN(Content))>= 32");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorID = 1,
                            Content = "On of my favourite movies of all time",
                            GenreId = 5,
                            ImagePath = "Images/Image_500.jpg",
                            IsDeleted = false,
                            Posted = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReleaseDate = new DateTime(2022, 10, 28, 13, 53, 55, 101, DateTimeKind.Local).AddTicks(1233),
                            Title = "Top Gun the new one"
                        },
                        new
                        {
                            Id = 2,
                            AuthorID = 2,
                            Content = "The bes spiderman movie so far, I love Tom Holand",
                            GenreId = 13,
                            ImagePath = "Images/Image_500.jpg",
                            IsDeleted = false,
                            Posted = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReleaseDate = new DateTime(2022, 10, 28, 13, 53, 55, 101, DateTimeKind.Local).AddTicks(1855),
                            Title = "Spiderman: Far From Home"
                        });
                });

            modelBuilder.Entity("MovieForum.Data.Models.Comment", b =>
                {
                    b.HasOne("MovieForum.Data.Models.User", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MovieForum.Models.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieForum.Data.Models.MovieActor", b =>
                {
                    b.HasOne("MovieForum.Data.Models.Actor", "Actor")
                        .WithMany("Roles")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MovieForum.Models.Movie", "Movie")
                        .WithMany("Cast")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieForum.Data.Models.MovieTags", b =>
                {
                    b.HasOne("MovieForum.Models.Movie", "Movie")
                        .WithMany("Tags")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MovieForum.Data.Models.Tag", "Tag")
                        .WithMany("Movies")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("MovieForum.Data.Models.Rating", b =>
                {
                    b.HasOne("MovieForum.Models.Movie", "Movie")
                        .WithMany("Rating")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieForum.Data.Models.Reaction", b =>
                {
                    b.HasOne("MovieForum.Data.Models.Comment", null)
                        .WithMany("Reactions")
                        .HasForeignKey("CommentId");
                });

            modelBuilder.Entity("MovieForum.Data.Models.User", b =>
                {
                    b.HasOne("MovieForum.Data.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MovieForum.Models.Movie", b =>
                {
                    b.HasOne("MovieForum.Data.Models.User", "Author")
                        .WithMany("Movies")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieForum.Data.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MovieForum.Data.Models.Actor", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("MovieForum.Data.Models.Comment", b =>
                {
                    b.Navigation("Reactions");
                });

            modelBuilder.Entity("MovieForum.Data.Models.Tag", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieForum.Data.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieForum.Models.Movie", b =>
                {
                    b.Navigation("Cast");

                    b.Navigation("Comments");

                    b.Navigation("Rating");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
