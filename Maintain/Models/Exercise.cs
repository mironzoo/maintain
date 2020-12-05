using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maintain.Models {
    public class Exercise {
        public Exercise(int id_, string name_) {
            id = id_;
            name = name_;
        }

        public int id { get;set; }
        public string name { get;set; }

        public int getId() {
            return id;
        }

        public string getName() {
            return name;
        }
    }
}
