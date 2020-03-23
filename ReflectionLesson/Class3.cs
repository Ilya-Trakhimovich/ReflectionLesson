using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Beer : Product
    {
        public string Color { get; set; }
        public Beer(string name, double cost, DateTime life, double quantity, string color) : base(name, cost, life, quantity)

        {
            Color = color;
        }
        public override void Method()
        {
            base.Method();
            Console.WriteLine("Пиво {0} - {1} ", Name, Color);
        }

    }
}
