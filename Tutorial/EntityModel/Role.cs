using System;

namespace Tutorial.Portal.EntityModel
{
    public class Role : BaseEntityModel
    {
        public string RoleName { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}