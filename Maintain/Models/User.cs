using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maintain.Models
{
    public class User
    {
        private int pid { get;set; }
        private string fname { get;set; }
        private string lname { get;set; }
        private int curr_weight { get;set; } //Whenever user chooses to update this value, create an entry for weight with 
        private List<int> followedfoodMenuIdList { get;set; } //contains a list of int ids associated with a food menu object
        
    }
}
