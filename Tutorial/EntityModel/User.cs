using System;

namespace Tutorial.Portal.EntityModel
{
    public class User : BaseEntityModel
    {
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public Gender Gender { get; set; }
        public DateTime LastLoginDate { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }
}