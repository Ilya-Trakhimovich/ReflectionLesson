using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Warehouse
{
    class Warehouse
    {
        string s = " ";
        double e = 0.0;
        DateTime k;
        double c = 0.0;
        public void Add()
        {
            List<Product> tovar = new List<Product>();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите пожалуйста товар, который хотите добавить на склад ");
                Console.WriteLine("Введите пожалуйста название товара, который хотите добавить на склад ");
                string s = Console.ReadLine();
                string[] words = s.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                string value = String.Concat<string>(words);
                Console.WriteLine("Введите пожалуйста цену товара, который хотите добавить на склад");


                while (flag)
                {
                    bool IsCost = double.TryParse(Console.ReadLine(), out double e);
                    if (e <= 0 || IsCost == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Проверьте правильность написания цены. Повторите снова");
                        Console.ResetColor();

                    }
                    if (IsCost == true)
                    {
                        break;
                    }
                }

                Console.WriteLine("Введите пожалуйста дату срока годности продукта, которого хотите добавить на склад");
                while (flag)
                {
                    bool IsDataTime = DateTime.TryParse(Console.ReadLine(), out DateTime k);
                    if (IsDataTime == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Проверьте правильность даты. Повторите снова");
                        Console.ResetColor();
                    }
                    if (IsDataTime == true)
                    {
                        break;
                    }
                }

                Console.WriteLine("Введите пожалуйста количество товара в кг, который хотите добавить на склад");
                while (flag)
                {
                    bool IsCol = double.TryParse(Console.ReadLine(), out double c);

                    if (IsCol == false || c <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Проверьте правильность написания количества продукта. Повторите снова");
                        Console.ResetColor();

                    }
                    if (IsCol == true)
                    {
                        break;
                    }
                }
                tovar.Add(new Fish_Product(value, e, k, c));
                foreach (Fish_Product pr in tovar)
                {

                    Console.WriteLine(" Название продукта {0}", value);
                    Console.WriteLine(" Стоимость продукта {0} $", e);
                    Console.WriteLine(" Годен до {0}", k);
                    Console.WriteLine(" Количество продукта {0} кг", c);
                    if (DateTime.Now <= pr.Life)
                    {
                        Console.WriteLine(" Продукты {0} не просрочены ", value);
                    }
                    else { Console.WriteLine(" Продукт {0} просрочен", value); }
                    Console.WriteLine("*********************************************");
                    break;

                }

                Console.WriteLine("Выберите категорию товара, которого вы добавляете: 1 - Мясная Продукция /n 2 - Молочная Продукция /n 3- Рыбная Продукция /n 4 - Пивная продукция");
                bool IsCategory = Int32.TryParse(Console.ReadLine(), out int cat);
                while (flag)
                {

                    switch (cat)
                    {

                        case 1:
                            Console.WriteLine("Вы выбрали катеогрию Мясная Продукция");
                            tovar.Add(new Meat_Product(value, e, k, c));
                            foreach (var pr in tovar)
                            {

                                Console.WriteLine(" Название продукта {0} - ", pr.Name);
                                Console.WriteLine(" Стоимость продукта {0} $", pr.Cost);
                                Console.WriteLine(" Годен до {0}", pr.Life);
                                Console.WriteLine(" Количество продукта {0} кг", pr.Quantity);
                                if (DateTime.Now <= pr.Life)
                                {
                                    Console.WriteLine(" Продукты {0} не просрочены ", pr.Name);
                                }
                                else { Console.WriteLine(" Продукт {0} просрочен", pr.Name); }
                                Console.WriteLine("*********************************************");
                                break;

                            }
                            break;
                        case 2:
                            Console.WriteLine("Вы выбрали катеогрию Молочная Продукция");
                            tovar.Add(new MilkProduct(value, e, k, c));
                            break;
                        case 3:
                            Console.WriteLine("Вы выбрали катеогрию Рыбная Продукция");
                            tovar.Add(new Fish_Product(value, e, k, c));
                            break;
                        case 4:
                            Console.WriteLine("Вы выбрали катеогрию Пивная Продукция");


                            Console.WriteLine("Введите сорт пива.....");
                            string z = Console.ReadLine();
                            if (z == "Светлое" || z == "Темное" || z == "Нефильтрованное")
                                tovar.Add(new Beer(value, e, k, c, z));
                            break;
                    }
                    break;
                }
                foreach (Product pr in tovar)
                {

                    Console.WriteLine(" Название продукта {0} - ", pr.Name);
                    Console.WriteLine(" Стоимость продукта {0} $", pr.Cost);
                    Console.WriteLine(" Годен до {0}", pr.Life);
                    Console.WriteLine(" Количество продукта {0} кг", pr.Quantity);
                    if (DateTime.Now <= pr.Life)
                    {
                        Console.WriteLine(" Продукты {0} не просрочены ", pr.Name);
                    }
                    else { Console.WriteLine(" Продукт {0} просрочен", pr.Name); }
                    Console.WriteLine("*********************************************");
                    break;

                }
            }
        }
    }
}