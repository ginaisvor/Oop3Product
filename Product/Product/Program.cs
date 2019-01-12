using System;

namespace Product
{
    class Program
    {
        public static void Main()
        {
            //beverage
            Beverage cola = new Beverage();
            cola.name = "Coca";
            cola.producer = "Coca Cola";
            cola.weight = 1.5f;
            cola.ProductionDate = new DateTime(2018, 12, 03);
            cola.Print();
            //dairy
            Dairy lapte = new Dairy();
            lapte.name = "ZUZU";
            lapte.producer = "Albalact";
            lapte.weight = 1f;
            lapte.ProductionDate = new DateTime(2018, 12, 03);
            lapte.Print();
            //fruit
            Fruit banana = new Fruit();
            banana.name = "Ciquita";
            banana.producer = "banana tree";
            banana.weight = 0.3f;
            banana.ProductionDate = new DateTime(2018, 12, 03);
            banana.Print();
            //bread
            Bread panica = new Bread();
            panica.name = "Yam Yam";
            panica.producer = "mamica";
            panica.weight = 0.230f;
            panica.ProductionDate = new DateTime(2018, 12, 03);
            panica.Print();
        }
    }
}
