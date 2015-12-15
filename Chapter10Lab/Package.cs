using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Lab
{
    class Package
    {
        public int IDNum { get; set; }
        public string RecipientName { get; set; }
        public double Weight { get; set; }
        protected double deliveryPrice;

        public Package(int id, string name, double w)
        {
            IDNum = id;
            RecipientName = name;
            Weight = w;
        }

        public virtual string SetPrice()
        {
            if (Weight <= 32)
            {
                deliveryPrice = 5;
            }
            else if (Weight > 32)
            {
                double extraWeight = Weight - 32;
                double extraCharge = extraWeight * 0.12;
                deliveryPrice = 5 + extraCharge;
            }
            string price = deliveryPrice.ToString("C");
            return price;
        }
    }
}
