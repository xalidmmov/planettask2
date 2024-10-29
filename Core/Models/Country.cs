using Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Core.Models
{
   public class Country
    {
        private static int _id = 0;
        public int cId { get; set; }
        public string cName { get; set; }
        public double cArea { get; set; }
        public string Anthem {  get; set; }
       
        public Region region { get; set; }
        public Country(string Name,double Area,string anthem)
        {
            cName = Name;
            cArea = Area;
            Anthem = anthem;
            ++_id;
            cId = _id;
           

        }
    }




}
