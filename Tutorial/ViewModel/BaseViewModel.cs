using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial.Portal.ViewModel
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
