using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class Fruit : Product
    {
        public override DateTime GetExpirationDate()
        {
            return this.ProductionDate.Date.AddDays(2);
        }
        public void Print()
        {
            Console.WriteLine("I'm a fruit. My name is {0} and I weight {1} kg, I was produced by {2} in {3} and I wil expire in {4}.\n", this.name, this.weight, this.producer, this.ProductionDate.ToShortDateString(), this.GetExpirationDate().ToShortDateString());
        }
    }
}
