using System;
using System.Collections.Generic;
using System.Text;

namespace IndWork_Uni
{
    class BankPc
    {
        public List<Account> accounts = new List<Account>(); //список карт
        public BankPc() //конструктор инициализации центрального компьютера банка
        {
            //добавление карт в список
            Account acc1 = new Account(98761234, 0);
            Account acc2 = new Account(12349876, 12345);
            Account acc3 = new Account(90901212, 50050);
            accounts.Add(acc1);
            accounts.Add(acc2);
            accounts.Add(acc3);
        }
    }
}
