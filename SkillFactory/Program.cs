using System;

namespace SkillFactory
{
    internal static class Program
    {
        static void Main()
        {
            PickPointDelivery delivery = new PickPointDelivery();
            Сlothes product = new Сlothes();
            Order<PickPointDelivery, Сlothes> order 
                = new Order<PickPointDelivery, Сlothes>(delivery, product, "Василий","dd@yandex.ru","995");
            //Статичный метод проверки наличия продукта в базе данных 
            HelpMetods.CheckAvailability(product);

            HelpMetods.ShowInfoAboutProduct<Product>(product);


            Console.ReadKey();
        }
    }
}





