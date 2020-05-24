using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class State
    {
        private string countrname, capital, continent;
        private long population, area;

        public string Countrname { get => countrname; set => countrname = (value != "" ? value : "Nan"); }
        public string Capital { get => capital; set => capital = (value != null ? value : "Nan"); }
        public string Continent { get => continent; set => continent = (value != "" ? value : "Nan"); }
        public long Population { get => population; set => population = (value > 0 ? value : -1); }
        public long Area { get => area; set => area = (value > 0 ? value : -1); }

        public State()
        {
            Console.WriteLine("New state was created!");
        }

        public State(string countrname, string capital, string continent, long population, long area)
        {
            Countrname = countrname;
            Capital = capital;
            Continent = continent;
            Population = population;
            Area = area;
        }

        public void Change(string object1, string value)
        {
            switch (object1)
            {
                case "Название":
                    this.Countrname = value;
                    break;
                case "Столица":
                    this.Capital = value;
                    break;
                case "Континент":
                    this.Continent = value;
                    break;
                case "Численность населения":
                    this.Population = Int64.Parse(value);
                    break;
                default:
                    this.Area = Int64.Parse(value);
                    break;
            }
        }
        
        public void Print()
        {
            Console.WriteLine("Country name: " + Countrname);
            Console.WriteLine("Country capital: " + Capital);
            Console.WriteLine("Country continent: " + Continent);
            Console.WriteLine("Country population: " + Population);
            Console.WriteLine("Country area: " + Area);
        }
    }
}
