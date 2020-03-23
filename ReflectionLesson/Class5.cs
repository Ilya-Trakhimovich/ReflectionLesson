using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    public class Product
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public DateTime Life { get; set; }
        public double Quantity { get; set; }

        public Product(string name, double cost, DateTime life, double quantity)
        {
            Name = name;
            Cost = cost;
            Life = life;
            Quantity = quantity;
        }
        public virtual void Method()
        {
            Console.WriteLine("Название продукта {0}", Name);
            Console.WriteLine("Стоимость продукта {0} $", Cost);
            Console.WriteLine("Годен до {0}", Life);
            Console.WriteLine("Количество продукта {0} кг", Quantity);
            if (DateTime.Now <= Life)
            {
                Console.WriteLine("Продукты {0} не просрочены ", Name);
            }
            else { Console.WriteLine("Продукт {0} просрочен", Name); }
        }

    }
}
