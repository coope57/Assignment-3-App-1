using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class property
    {
        public int number { get; set; }    
        public string inventory { get; set; }
        public string  item { get; set; }
        public int price{ get; set; }
        public int count{ get; set; }
        public void save()
        {
            Console.WriteLine("saved succesfully");
        }

    }
}
