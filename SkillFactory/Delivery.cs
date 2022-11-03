using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory
{
    abstract class Delivery
    {
        public string Address;
        public abstract void MoveOrder();
    }

    class HomeDelivery : Delivery
    {
        public Firma firma;
        public HomeDelivery()
        {
            firma = new Firma();
        }
        public override void MoveOrder()
        {
            //Метод доставки на дом
        }
    }

    class PickPointDelivery : Delivery
    {
        public Firma firma;
        public PickPointDelivery()
        {
            firma = new Firma();
        }
        public override void MoveOrder()
        {
            //Метод доставки на до пикпоинта
        }
    }

    class ShopDelivery : Delivery
    {
        //ДатаВремя начала работы магазина
        public DateTime startWork;
        //ДатаВремя окончания работы магазина
        public DateTime endWork;
        Firma firma;
        public ShopDelivery()
        {
            firma = new Firma();
        }
        public override void MoveOrder()
        {
            //Метод доставки на до магазина
        }
    }
}
