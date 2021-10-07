using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication2.Models
{
    public class ModelDep
    {
        

        private string v;

        public ModelDep()
        {
        }

        public ModelDep(string v)
        {
            this.v = v;
        }

        public int id { get; set; }
        public string name { get; set; }
        public  String ModDep()
        {
          
            return "testzze";
          

        }

    }
}
