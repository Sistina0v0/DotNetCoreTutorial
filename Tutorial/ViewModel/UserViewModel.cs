using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tutorial.Portal.EntityModel;

namespace Tutorial.Portal.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        [Required, Range(0, 20)]
        public string LoginName { get; set; }
        [Required, Range(0, 20)]
        public string UserName { get; set; }
        [Required, Range(0, 24), DataType(DataType.Password)]
        public string Pwd { get; set; }
        public Gender Gender { get; set; }
        public DateTime LastLoginDate { get; set; }
        [Range(typeof(DateTime), "1900/1/1", "2100/1/1")]
        public DateTime BirthDate { get; set; }
        public IsDelete IsDelete { get; set; }
    }
}
