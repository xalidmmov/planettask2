using Core.Data;
using Core.Helper;
using Core.Models;
using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace planettask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDBContext db = new AppDBContext();

            bool m1 = false;
            bool m2 = false;
            bool m3 = false;
            bool m4 = false;







            bool deyisen = false;

            do
            {

                Console.WriteLine("************PLANETS AND COUNTRIES  MENU***************");
                Console.WriteLine("1.Sisteme giris    0.CIXIS");
                int giris1;
                do
                {
                    deyisen = int.TryParse(Console.ReadLine(), out giris1);
                    if (deyisen == false)
                    {

                        Console.WriteLine("REQEM DAXIL EDIN !!!");

                    }
                } while (!deyisen);
                switch (giris1)
                {
                    case 0: m1 = true; break;
                    case 1:

                        Console.Clear();
                        do
                        {
                            Console.WriteLine("1.PLANET   2.COUNTRIES     3.BACK");
                            int giris2;
                            deyisen = int.TryParse(Console.ReadLine(), out giris2);
                            if (deyisen == false)
                            {
                                Console.WriteLine("REQEM DAXIL EDIN");
                            }
                            switch (giris2)
                            {
                                case 1:
                                    Console.Clear();
                                    do
                                    {
                                        Console.WriteLine("*************Planet************");
                                        Console.WriteLine("1.Planet Yarat  2.Planet Sil  3.Planetleri goster  4.BACK");
                                        int giris3;
                                        deyisen = int.TryParse(Console.ReadLine(), out giris3);
                                        if (deyisen == false)
                                        {
                                            Console.WriteLine("REQEM DAXIL EDIN ");

                                        }
                                        switch (giris3)
                                        {
                                            case 4:

                                                Console.Clear();
                                                m3 = true; break;
                                            case 1:

                                                Console.Clear();
                                                Console.Write("Ad : ");
                                                string planetadi = Console.ReadLine();
                                                Console.Write("Erazi :");
                                                double planeterazisi;
                                                do
                                                {
                                                    deyisen = double.TryParse(Console.ReadLine(), out planeterazisi);
                                                    if (deyisen == false)
                                                    {

                                                        Console.WriteLine("REQEM DAXIL EDIN ");

                                                    }
                                                } while (!deyisen);
                                                Planet planet = new Planet(planetadi, planeterazisi);
                                                db.CreatePlanet(planet);
                                                break;
                                            case 2:
                                                db.GetAllPlanets();
                                                Console.Write("Silmek istediyiniz planetin id : ");
                                                int planetid;
                                                do
                                                {
                                                    deyisen = int.TryParse(Console.ReadLine(), out planetid);
                                                    if (deyisen == false)
                                                    {

                                                        Console.WriteLine("REQEM DAXIL EDIN ");

                                                    }
                                                } while (!deyisen);
                                                db.RemovePlanet(planetid);
                                                break;
                                            case 3:

                                                var planets = db.GetAllPlanets();
                                                foreach (var p in planets)
                                                {
                                                    Console.WriteLine($"name {p.name}  area  {p.area}");
                                                }
                                                break;

                                        }

                                    } while (!m3);

                                    break;

                                case 2:

                                    Console.Clear();
                                    do
                                    {
                                        Console.WriteLine("***********Countries***********");
                                        Console.WriteLine("1.Olke Yarat  2.Olkelere bax   3.Olke sil   4.Olke adi deyis   5.Back");
                                        int giris4;
                                        deyisen = int.TryParse(Console.ReadLine(), out giris4);
                                        if (deyisen == false)
                                        {
                                            Console.WriteLine("REQEM DAXIL EDIN ");
                                        }
                                        switch (giris4)
                                        {
                                            case 5:
                                                Console.Clear();
                                                m4 = true; break;
                                            case 1:
                                                Console.Clear();
                                                Console.Write("Olke adi : ");
                                                string olkeadi = Console.ReadLine();
                                                Console.Write("Olke erazisi : ");
                                                double olkerazisi;
                                                do
                                                {
                                                    deyisen = double.TryParse(Console.ReadLine(), out olkerazisi);
                                                    if (deyisen == false)
                                                    {
                                                        Console.WriteLine("REQEM DAXIL EDIN ");
                                                    }
                                                } while (!deyisen);
                                                Console.Write("Olke himni : ");
                                                string olkehimni = Console.ReadLine();
                                                Country country = new Country(olkeadi, olkerazisi, olkehimni);
                                                Console.WriteLine("Region secin : 1.Avropa 2.Asiya 3.Amerika   4.Afrika  5.Avstraliya");
                                                Console.Write("Seciminiz : ");
                                                int olkeregion;
                                                deyisen = int.TryParse(Console.ReadLine(), out olkeregion);
                                                if (deyisen == false)
                                                {
                                                    Console.WriteLine("REQEM DAXIL EDIN ");
                                                }
                                                db.CreateCountry(country);
                                                Region region = new Region();
                                                switch (olkeregion)
                                                {
                                                    case 1: region = Region.Avropa; break;
                                                    case 2: region = Region.Asiya; break;
                                                    case 3: region = Region.Amerika; break;
                                                    case 4: region = Region.Afrika; break;
                                                    case 5: region = Region.Avstraliya; break;
                                                }
                                                country.region = region;

                                                break;
                                            case 2:

                                                var countries = db.GetAllCountries();
                                                foreach (var c in countries)
                                                {
                                                    Console.WriteLine($"name  {c.cName}  area  {c.cArea}  himn{c.Anthem}  region {c.region}");
                                                }

                                                break;
                                            case 3:
                                                db.GetAllPlanets();
                                                Console.WriteLine("Silinecek olkenin id si : ");
                                                int olkeid;
                                                deyisen = int.TryParse(Console.ReadLine(), out olkeid);
                                                if (deyisen == false)
                                                {
                                                    Console.WriteLine("REQEM DAXIL EDIN");

                                                }
                                                db.RemoveCountry(olkeid);
                                                break;
                                            case 4:

                                                Console.Clear();
                                                db.GetAllCountries();
                                                Console.Write("Adini deyismek istediyiniz olkenin id : ");
                                                int olkeid2;
                                                deyisen = int.TryParse(Console.ReadLine(), out olkeid2);
                                                if (deyisen == false)
                                                {

                                                    Console.WriteLine("REQEM DAXIL EDIN ");

                                                }
                                                Console.Write("Yeni ad : ");
                                                string yeniad = Console.ReadLine();
                                                db.UpdateCountry(olkeid2, yeniad);
                                                break;


                                        }


                                    } while (!m4);
                                    break;

                                case 3:
                                    Console.Clear();
                                    m2 = true; break;


                            }

                        } while (!m2);


                        break;

                }


            } while (!m1);
        }
    }
}






