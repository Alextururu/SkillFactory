using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    internal class Order<TDelivery,TProduct> 
        where TDelivery : Delivery 
        where TProduct : Product
    {
        //Тип доставки
        protected internal TDelivery delivery;
        //Тип заказа
        protected internal TProduct product;
        //Заказчик доставки
        protected internal Person customer;

        protected internal int Number;
        protected internal string Description;

        public Order(TDelivery delivery, TProduct product, string namePerson, string mailPerson, string phonePerson)
        {
            customer = new Person(namePerson, mailPerson, phonePerson);
            this.delivery = delivery;
            this.product = product;
        }

        public void DisplayAddress()
        {
            Console.WriteLine("Ваш заказ будет доставлен по адресу: " + delivery.Address);
        }

        public void DisplayOrderInfo()
        {
            Console.WriteLine("Ваш заказ: " + product.nameProduct);
            if (product is Сlothes)
            {
                Сlothes clothes = product as Сlothes;
                Console.WriteLine("Размер: " + clothes.size);
                Console.WriteLine("Цвет: " + clothes.color);
            }
            if (product is Technics)
            {
                Technics technics = product as Technics;
                Console.WriteLine("Модель: " + technics.model);
                Console.WriteLine("Производитель: " + technics.manufacture);
            }
        }
        public void DisplayInfoDelivery()
        {
            if (delivery is HomeDelivery)
            {
                HomeDelivery homeDelivery = delivery as HomeDelivery;
                Console.WriteLine("Доставит фирма: " + homeDelivery.firma.nameFirma);
            }
            if (delivery is PickPointDelivery)
            {
                PickPointDelivery pickPointDelivery = delivery as PickPointDelivery;
                Console.WriteLine("Даставка будет в точку доставки: " + pickPointDelivery.firma.nameFirma);
            }
        }
    }
}
