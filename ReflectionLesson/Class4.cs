using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Meat_Product : Product
    {
        public Meat_Product(string name, double cost, DateTime life, double quantity) : base(name, cost, life, quantity)
        {

        }
        public override void Method()
        {
            base.Method();
        }

    }
}
