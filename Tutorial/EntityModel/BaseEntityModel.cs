﻿using System;

namespace Tutorial.Portal.EntityModel
{
    public class BaseEntityModel
    {
        public int Id { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
