using System;
using System.Collections.Generic;
using System.Text;

namespace IndWork_Uni
{
    class ATM
    {
        public BankPc bankPc = new BankPc(); //центральный компьютер банка
        public List<Account> blockedCards = new List<Account>(); //храниище заблокированных карт
        public int[,] storage = { {5000, 10 }, { 1000, 100 }, { 500, 100 }, { 100, 100 } }; //хранилище денег {номинал, количество купюр}
        
        public bool checkBlocked(int accountNumber) //проверка не заблокирована ли карта
        {
            bool isBlocked = false;
            if (blockedCards.Count > 0) //если в списке есть заблокированные карты
            {
                //поиск карты в списке заблокированных карт
                foreach (Account blockedAccount in blockedCards)
                {
                    if (blockedAccount.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке заблокированных карт
                    {
                        isBlocked = true; //карта заблокирована
                        break;
                    }
                }
            }
            return isBlocked;
        }
        public bool checkNumber(int accountNumber) //проверка есть ли такая карта в списке карт
        {
            bool isNumber = false;
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                {
                    isNumber = true; //карта найдена
                    break;
                }
            }
            return isNumber;
        }

        public bool checkPincode(int accountPincode, int accountNumber) //проверка правильности пинкода
        {
            bool correctPin = false;
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.pinCode == accountPincode && account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                { //и введенный пинкод совпадает с пинкодом карты из списка
                    correctPin = true; //пинкод верный
                    break;
                }
            }
            return correctPin;
        }

        public void blockAccount(int accountNumber) //добавление карты в список заблокированных карт и конфискуется
        {
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                {
                    blockedCards.Add(account); //добавить карту в хранилище заблокированных карт
                    break;
                }
            }
        }

        public int balance(int accountNumber) //узнать баланс карты
        {
            int balance = 0;
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                {
                    balance = account.money; //получаем баланс карты
                    break;
                }
            }
            return balance;
        }

        public bool payment(int accountNumber, int sum) //проведение безналичного платежа
        {
            bool isSuccessfully = false;
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                {
                    if(account.money - sum >= 0) //если на карте достаточно денег для перевода
                    {
                        account.money -= sum; //вычитаем введенную сумму со счета
                        isSuccessfully = true; //операция прошла успешно
                    }
                    break;
                }
            }
            return isSuccessfully;
        }

        public string reportCash(int accountNumber, int sum) //печать справки о снятии наличных
        {
            string report = "";
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                {
                    report = "***СПРАВКА***\nНомер счета: " + account.number + "\nСнятие наличных: " + sum + "\nОстаток на счету: " + account.money; //текст справки
                    break;
                }
            }
            return report;
        }

        public string reportMoney(int accountNumber) //печать справки об остатке на счету
        {
            string report = "";
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                {
                    report = "***СПРАВКА***\nНомер счета: " + account.number + "\nОстаток на счету: " + account.money; //текст справки
                    break;
                }
            }
            return report;
        }

        public bool checkMoney(int accountNumber, int sum) //проверка можно ли снять со счета эту сумму
        {
            bool isSuccessfully = false;
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                {
                    if (account.money - sum >= 0) //хватает ли денег на счету для снятия наличных
                    {
                        isSuccessfully = true; //денег хватает
                    }
                    break;
                }
            }
            return isSuccessfully;
        }

        public bool giveMoney(int accountNumber, int sum)
        {
            bool isSuccessfully = false;
            //поиск карты в списке карт
            foreach (Account account in bankPc.accounts)
            {
                if (account.number == accountNumber) //если номер введенной карты совпадает с номером карты в списке карт
                {
                    for(int i = 0; i < storage.GetLength(0); i++) //цикл по номиналам купюр из хранилища в банкомате
                    {
                        //если количество купюр i-го номинала достаточно в банкомате, чтобы покрыть введенную сумму 
                        // и сумма делится на i-ый номинал нацело
                        if (((sum / storage[i, 0]) <= storage[i, 1]) && ((sum % storage[i, 0]) == 0))
                        {
                            storage[i, 1] = storage[i, 1] - (sum / storage[i, 0]); //вычитаем нужное количество купюр i-того номинала из банкомата
                            account.money -= sum; //вычитаем сумму со счета
                            isSuccessfully = true; //операция прошла успешно
                            break;
                        }
                    }
                    break;
                }
            }
            return isSuccessfully;
        }
    }
}
