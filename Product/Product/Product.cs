using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public abstract class Product
    {
        public float weight;
        public string name;
        public DateTime productionDate;
        public DateTime expirationDate;
        public string producer;

        public DateTime ProductionDate
        {
            get
            {
                return this.productionDate;
            }
            set
            {
                this.productionDate = value;
            }
        }

        public abstract DateTime GetExpirationDate();
    }
}
