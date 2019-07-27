using System;
using System.ComponentModel.DataAnnotations;

namespace Tutorial.Portal.EntityModel
{
    public class User : BaseEntityModel
    {
        public string UserName { get; set; }
        public string LoginName { get; set; }
        public string Pwd { get; set; }
        public Gender Gender { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime BirthDate { get; set; }
        public IsDelete IsDelete { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public enum IsDelete
    {
        Normal = 0,
        Deleted = 1
    }
}