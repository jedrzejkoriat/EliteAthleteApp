﻿// <auto-generated />
using System;
using EliteAthleteApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EliteAthleteApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoachId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExerciseCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ExerciseMediaId")
                        .HasColumnType("int");

                    b.Property<int?>("ExerciseMuscleGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SetAsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("YoutubeLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingExercises");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingExerciseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingExerciseCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Conditioning"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Strength"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mobility"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Stretching"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Plyometrics"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Dynamics"
                        },
                        new
                        {
                            Id = 7,
                            Name = " "
                        });
                });

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingExerciseMedia", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("ImageUrls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingExerciseMedias");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingExerciseMuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingExerciseMuscleGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = " "
                        },
                        new
                        {
                            Id = 2,
                            Name = "Neck"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Shoulders"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Core"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Triceps"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Forearms/Wrist"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Back"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Glutes"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Lower Back"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Quadriceps"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Hamstrings"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Calves"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Trapezius"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Adductors"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Abductors"
                        });
                });

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoachId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrainingPlanIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingModules");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingOrm", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("BenchPressOrm")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeadliftOrm")
                        .HasColumnType("int");

                    b.Property<int?>("OverheadPressOrm")
                        .HasColumnType("int");

                    b.Property<int?>("SquatOrm")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingOrms");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoachId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmpty")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingModuleId")
                        .HasColumnType("int");

                    b.Property<string>("TrainingPlanExerciseDetailIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlans");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingPlanExerciseDetail", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<string>("Index")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingPlanPhaseId")
                        .HasColumnType("int");

                    b.Property<string>("Units")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlanExerciseDetails");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.TrainingPlanPhase", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlanPhases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = " "
                        },
                        new
                        {
                            Id = 2,
                            Name = "Warm-up"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mobility"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Strength Training"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Core Training"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cardio/Conditioning"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Cool Down"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Stretching"
                        });
                });

            modelBuilder.Entity("EliteAthleteApp.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CoachId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InviteCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NewCoachId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int?>("UserSubscriptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "654bced5-375b-5291-0a59-1dc59923d1b0",
                            AccessFailedCount = 0,
                            CoachId = "654bced5-375b-5291-0a59-1dc59923d1b0",
                            ConcurrencyStamp = "5af11608-cf7f-4684-99ec-753300120d00",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            InviteCode = "1b0",
                            LastName = "System",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIasK/JJG7fr6SVpeg7UFINUP0/OYHb8Ik0VefpNMG4BHlOjW5gtAwxdqR2hw8/4Ug==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1ca50dfc-6cc8-4d13-8ff1-d1db66839f2c",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com",
                            UserSubscriptionId = 4
                        },
                        new
                        {
                            Id = "654bced5-375b-5291-0a59-1dc59923d1b1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f8505d6b-d057-47e1-8b16-4ca3b350d6dd",
                            Email = "user@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "User",
                            InviteCode = "1b1",
                            LastName = "System",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@LOCALHOST.COM",
                            NormalizedUserName = "USER@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELgxQ0A4/LZAofXC0uN4U9xgfVDwqdrRCa8NCvVYomWklJYaAiyLmq0iWttsdYL2VQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "61d2a6b0-4ae9-46fd-bd2b-52777fa72d06",
                            TwoFactorEnabled = false,
                            UserName = "user@localhost.com",
                            UserSubscriptionId = 1
                        },
                        new
                        {
                            Id = "654bced5-375b-5291-0a59-1dc59923d1b2",
                            AccessFailedCount = 0,
                            CoachId = "654bced5-375b-5291-0a59-1dc59923d1b2",
                            ConcurrencyStamp = "aca3b167-20ac-41a2-ac5d-3cd3a75f9b65",
                            Email = "coach@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Coach",
                            InviteCode = "1b2",
                            LastName = "System",
                            LockoutEnabled = false,
                            NormalizedEmail = "COACH@LOCALHOST.COM",
                            NormalizedUserName = "COACH@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEufwanAYTqehCCrTb0zCi7CsgF3AQu1EKzgTCBWIkXBzPXpd+7q8sS6+3BXkJ5JzA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9d9f62aa-ba80-4310-afe9-43672550005f",
                            TwoFactorEnabled = false,
                            UserName = "coach@localhost.com",
                            UserSubscriptionId = 2
                        });
                });

            modelBuilder.Entity("EliteAthleteApp.Data.UserBodyAnalysis", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FatPercentage")
                        .HasColumnType("int");

                    b.Property<string>("FileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MusclePercentage")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WaterPercentage")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserBodyAnalysis");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.UserBodyMeasurements", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("Arms")
                        .HasColumnType("int");

                    b.Property<int?>("Chest")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Hips")
                        .HasColumnType("int");

                    b.Property<int?>("Thighs")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Waist")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserBodyMeasurements");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.UserChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChatUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoachId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserChats");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.UserMedicalTest", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserMedicalTests");
                });

            modelBuilder.Entity("EliteAthleteApp.Data.UserSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AthleteLimit")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrivateExerciseLimit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserSubscriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AthleteLimit = 0,
                            Name = "Athlete",
                            PrivateExerciseLimit = 0
                        },
                        new
                        {
                            Id = 2,
                            AthleteLimit = 3,
                            Name = "Free",
                            PrivateExerciseLimit = 5
                        },
                        new
                        {
                            Id = 3,
                            AthleteLimit = 10,
                            Name = "Basic",
                            PrivateExerciseLimit = 20
                        },
                        new
                        {
                            Id = 4,
                            AthleteLimit = 200,
                            Name = "Premium",
                            PrivateExerciseLimit = 200
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "543bced5-375b-5291-0a59-1dc59923d1b0",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "543bced5-375b-5291-0a59-1dc59923d1b1",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "543bced5-375b-5291-0a59-1dc59923d1b2",
                            Name = "Coach",
                            NormalizedName = "COACH"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "654bced5-375b-5291-0a59-1dc59923d1b0",
                            RoleId = "543bced5-375b-5291-0a59-1dc59923d1b0"
                        },
                        new
                        {
                            UserId = "654bced5-375b-5291-0a59-1dc59923d1b1",
                            RoleId = "543bced5-375b-5291-0a59-1dc59923d1b1"
                        },
                        new
                        {
                            UserId = "654bced5-375b-5291-0a59-1dc59923d1b2",
                            RoleId = "543bced5-375b-5291-0a59-1dc59923d1b2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EliteAthleteApp.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EliteAthleteApp.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EliteAthleteApp.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EliteAthleteApp.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
