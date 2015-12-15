using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Lab
{
    class InsuredPackage : Package
    {
        private double packageValue;

        public double PackageValue
        {
            get
            {
                return packageValue;
            }
        }

        public InsuredPackage(int id, string nm, int w) : base(id, nm, w)
        {

        }

        public override string SetPrice()
        {
            if (Weight <= 32)
            {
                deliveryPrice = 5;
                if (deliveryPrice < 20)
                {
                    packageValue = 1;
                    deliveryPrice += packageValue;
                }
            }
            else if (Weight > 32)
            {
                double extraWeight = Weight - 32;
                double extraCharge = extraWeight * 0.12;
                deliveryPrice = 5 + extraCharge;
                if (deliveryPrice < 20)
                {
                    packageValue = 1;
                    deliveryPrice += packageValue;
                }
                else if (deliveryPrice >= 20)
                {
                    packageValue = 2.5;
                    deliveryPrice += packageValue;
                }
            }
            string price = deliveryPrice.ToString("C");
            return price;
        }
    }
}
