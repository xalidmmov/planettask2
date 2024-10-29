using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Planet
    {
        private static int _id;
        public int pId { get; set; }
        public string name { get; set; }
        public double area {  get; set; }
        public Planet(string Name,double Area)
        {
            name = Name;
            area = Area;
            ++_id;
            pId = _id;
        }

    }
}
