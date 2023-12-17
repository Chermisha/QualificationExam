using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAccounting
{
    public class Service
    {
        private static int nextId = 1;
        public int Id { get; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }

        public Service(string name, double cost, string description)
        {
            Id = nextId;
            nextId++;
            Name = name;
            Cost = cost;
            Description = description;
        }

        public override string ToString()
        {
            return Id +": " + Name + " - " + Cost.ToString("C");
        }

        public static Service GetServiceObject(int id)
        {
            foreach (Service service in ServiceList.Services)
            {
                if (service.Id == id)
                {
                    return service;
                }
            }
            return null;
        }

        //public void Remove()
        //{
        //    this.Remove();
        //}

    }
}
