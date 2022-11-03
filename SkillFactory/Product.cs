using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    abstract class Product
    {
        public string nameProduct;

    }

    class Сlothes : Product
    {
        public string size;
        public string color;
    }

    class Technics : Product
    {
        public string model;
        public string manufacture;
    }

    class HelpMetods
    {
        public static bool CheckAvailability(Product product)
        {
            bool hasAvailability = false;
            //Злесь идет проверка наличия товара в базе данных наличия на складе
            //и если товар есть то переменная hasAvailability - меняет свое значение на true
            return hasAvailability;
        }
        public static void ShowInfoAboutProduct<T>(T prod)
        {
            if(prod is Сlothes)
            {
                Console.WriteLine("Ваш заказ - одежда!");
            }
            if (prod is Technics)
            {
                Console.WriteLine("Ваш заказ - техника!");
            }
        }
    }

}
