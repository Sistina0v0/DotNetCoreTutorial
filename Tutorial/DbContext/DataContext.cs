﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tutorial.Portal.EntityModel;

namespace Tutorial.Portal.DbContext
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new User
                {
                    Id = 1, LastLoginDate = DateTime.Now, Gender = Gender.Female, LoginName = "1", UserName = "1",
                    Pwd = "1", BirthDate = DateTime.Now.AddYears(-20), IsDelete = IsDelete.Normal,
                    ModifiedUser = "AdminInit", ModifiedTime = DateTime.Now
                },
                new User
                {
                    Id = 2, LastLoginDate = DateTime.Now, Gender = Gender.Female, LoginName = "Admin",
                    UserName = "Admin", Pwd = "Admin", BirthDate = DateTime.Now.AddYears(-22),
                    IsDelete = IsDelete.Normal, ModifiedUser = "AdminInit", ModifiedTime = DateTime.Now
                },
                new User
                {
                    Id = 3, LastLoginDate = DateTime.Now, Gender = Gender.Female, LoginName = "Zhangsan",
                    UserName = "张三", Pwd = "Zhangsan", BirthDate = DateTime.Now.AddYears(-23),
                    IsDelete = IsDelete.Normal, ModifiedUser = "AdminInit", ModifiedTime = DateTime.Now
                },
                new User
                {
                    Id = 4, LastLoginDate = DateTime.Now, Gender = Gender.Male, LoginName = "Lisi", UserName = "李四",
                    Pwd = "Lisi", BirthDate = DateTime.Now.AddYears(-18), IsDelete = IsDelete.Normal,
                    ModifiedUser = "AdminInit", ModifiedTime = DateTime.Now
                }
            });

            modelBuilder.Entity<Role>().HasData(new List<Role>
            {
                new Role {Id = 1, ModifiedTime = DateTime.Now, ModifiedUser = "AdminInit", RoleName = "炒鸡管理员",},
                new Role {Id = 2, ModifiedTime = DateTime.Now, ModifiedUser = "AdminInit", RoleName = "扫地阿姨"},
                new Role {Id = 3, ModifiedTime = DateTime.Now, ModifiedUser = "AdminInit", RoleName = "部门经理"},
                new Role {Id = 4, ModifiedTime = DateTime.Now, ModifiedUser = "AdminInit", RoleName = "HR"}
            });

            modelBuilder.Entity<UserRole>().HasData(new List<UserRole>
            {
                new UserRole {Id = 1, RoleId = 1, UserId = 1, ModifiedTime = DateTime.Now, ModifiedUser = "AdminInit"},
                new UserRole {Id = 2, RoleId = 2, UserId = 2, ModifiedTime = DateTime.Now, ModifiedUser = "AdminInit"},
                new UserRole {Id = 3, RoleId = 3, UserId = 3, ModifiedTime = DateTime.Now, ModifiedUser = "AdminInit"},
                new UserRole {Id = 4, RoleId = 4, UserId = 4, ModifiedTime = DateTime.Now, ModifiedUser = "AdminInit"}
            });
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
