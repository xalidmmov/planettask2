using Core.Helper;
using Core.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public class AppDBContext
    {
        public List<Country> countries = new List<Country>();
        public List<Planet> planets = new List<Planet>();
        public void CreateCountry(Country country)
        {
            countries.Add(country);
        }
        public void UpdateCountry(int countryId, string newName)
        {
            foreach (var country in countries)
            {
                if (country.cId == countryId)
                {
                    country.cName = newName;
                    
                    break;
                }
            }
            Console.WriteLine("olde adi deyisdirildi");
        }
        public void RemoveCountry(int countryId)
        {
            Country country = countries.Find(x => x.cId == countryId);
            countries.Remove(country);
            Console.WriteLine("silindi");

        }
        public List<Country> GetAllCountries()
        {
            return countries;  
        }
        public List<Country> GetCountryByRegion(Region sregion)
        {        
            List<Country> nlist = new List<Country>();
            foreach (var country in countries)
            {
                if (country.region == sregion)
                    nlist.Add(country);
            }
            return nlist;
        }

        public void CreatePlanet(Planet planet)
        {
            planets.Add(planet);
        }
        public void UpdatePlanet(int planetId, string planetName)
        {
            foreach (var planet in planets)
            {
                if (planet.pId == planetId)
                {
                    planet.name = planetName;
                    
                    break;
                }
            }
            Console.WriteLine("Olde adi deyisdirildi");

        }
        public void RemovePlanet(int planetId)
        {
            Planet planet =planets.Find(x => x.pId == planetId);
            planets.Remove(planet);
            Console.WriteLine("silindi");
        }
        public List<Planet> GetAllPlanets()
        {   
            return planets;
        }
        

    }
}
