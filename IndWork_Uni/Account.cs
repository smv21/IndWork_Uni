using System;
using System.Collections.Generic;
using System.Text;

namespace IndWork_Uni
{
    class Account
    {
        public int number; //номер карты
        public int pinCode; //пикнрд карты
        public int money; //количество денег на счету

        public Account(int number, int money) //конструктор инициализации счета
        {
            this.number = number;
            this.money = money;
            pinCode = number / 10000; //вычисление пинкода карты
        }
    }
}
