using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndWork_Uni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ATM atm; //банкомат
        int checkCardNumber; //введеный номер карты
        int trycounter = 0; //количество попыток
        int operation; //тип операции ( 0 - снятие наличных, 1 - узнать остаток на счету)

        private void Form1_Load(object sender, EventArgs e)
        {
            atm = new ATM(); //создаем объект банкомата
        }

        private void button_checknumber_Click(object sender, EventArgs e) //клик на кнопку "Ввод карты"
        {
             //делаем недоступными некоторые элементы и сбрасываем лейблы
            button_cash.Enabled = false;
            button_money.Enabled = false;
            button_payment.Enabled = false;
            button_reportmoney.Enabled = false;
            button_sum.Enabled = false;
            textBox_sum.Enabled = false;
            checkBox_report.Enabled = false;
            label_sum.Text = "Введите сумму денег";
            label_report.Text = "";

            checkCardNumber = Convert.ToInt32(textBox_cardnumber.Text); //считываем номер карты из текстбокса
            if (atm.checkBlocked(checkCardNumber)) //если карта найдена в хранилище заблокированных карт
            {
                label_info.Text = "Карта заблокирована.";
                button_checkpincode.Enabled = false;
                textBox_pincode.Enabled = false;
            }
            else //если карта не в хранилище заблокированных карт
            {
                if (atm.checkNumber(checkCardNumber)) //если карта есть в списке карт
                {
                    textBox_pincode.Enabled = true;
                    button_checkpincode.Enabled = true;
                    label_info.Text = "Карта найдена.";
                    label_pincodeinfo.Text = "Введите пин-код";
                }
                else //если карты нет в списке карт
                {
                    label_info.Text = "Номер карты неверный";
                }
            }
            label_counter.Text = "";
        }

        private void button_checkpincode_Click(object sender, EventArgs e) //клик на кнопку "Ввести пин"
        {
            int checkPinCode = Convert.ToInt32(textBox_pincode.Text); //считываем пин из тексбокса
            bool correctPin = atm.checkPincode(checkPinCode, checkCardNumber);
            if (correctPin) //если пин правильный
            {
                label_pincodeinfo.Text = "Пинкод верный";
                label_counter.Text = "";
                button_cash.Enabled = true;
                button_money.Enabled = true;
                button_payment.Enabled = true;
            }
            else //если пин неправильный
            {
                label_pincodeinfo.Text = "Пин-код неверный";
                button_cash.Enabled = false;
                button_money.Enabled = false;
                button_payment.Enabled = false;
                button_reportmoney.Enabled = false;
                button_sum.Enabled = false;
                textBox_sum.Enabled = false;
                label_sum.Text = "Введите сумму денег";
                label_report.Text = "";
            }

            if (!correctPin && trycounter <= 2) //если попыток меньше или равно двух
            {
                trycounter++; //увеличиваем число попыток
                label_counter.Text = "Осталось попыток: " + (3 - trycounter);
            }
            if (!correctPin && trycounter == 3) //если количество попыток уже равно 3
            {
                label_counter.Text = "Карта заблокирована"; 
                button_checkpincode.Enabled = false;
                textBox_pincode.Enabled = false;
                atm.blockAccount(checkCardNumber); //добавляем карту в список заблокированных и конфискуем ее
            }
        }

        private void button_cash_Click(object sender, EventArgs e)  //клик на кнопку "Снять наличные"
        {
            checkBox_report.Enabled = true;
            textBox_sum.Enabled = true;
            button_sum.Enabled = true;
            operation = 0; //меняем тип текущей операции на снятие наличных
        }

        private void button_money_Click(object sender, EventArgs e)   //клик на кнопку "Узнать остаток на счету"
        {
            label_display.Text = "На счету: " + atm.balance(checkCardNumber).ToString(); //выводим баланс карты на дисплей
            button_reportmoney.Enabled = true;
        }

        private void button_payment_Click(object sender, EventArgs e)   //клик на кнопку "Безналичный платеж"
        {
            textBox_sum.Enabled = true;
            button_sum.Enabled = true;
            operation = 1; //меняем тип текущей операции на снятие наличных
        }

        private void button_sum_Click(object sender, EventArgs e)   //клик на кнопку "Ввести сумму"
        {
            int sum = Convert.ToInt32(textBox_sum.Text); //считываем сумму из текстбокса
            if (operation == 0) //если до этого выбрана операция снятия наличных
            {
                if(atm.checkMoney(checkCardNumber, sum)) //если на счету хватает стредств для снятия
                {
                    if(atm.giveMoney(checkCardNumber, sum)) //если в банкомате хватило купюр и операция прошла успешно
                    {
                        label_sum.Text = "Снятие наличных прошло успешно";
                        label_display.Text = "Выньте карту";

                        if(checkBox_report.Checked) //если выбрана печать справки
                        {
                            label_report.Text = atm.reportCash(checkCardNumber, sum); //печать справки по снятию наличных
                        }
                    }
                    else //если в банкомате на хватило купюр
                    {
                        label_sum.Text = "Банкомат не может выдать эту сумму";
                    }
                }
                else //если на счету не достаточно средств для снятия
                {
                    label_sum.Text = "Недостаточно средств на счету";
                }
            }
            else if(operation == 1) //если до этого выбрана операция перевода
            {
                if (atm.payment(checkCardNumber, sum)) //если операция безналичного перевода прошла успешно
                {
                    label_sum.Text = "Сумма переведена";
                }
                else  //если операция безналичного перевода прошла не успешно
                {
                    label_sum.Text = "Недостаточно средств на счету";
                }
            }
        }

        private void button_reportmoney_Click(object sender, EventArgs e)   //клик на кнопку "Напечатать справку по остатку на счету"
        {
            label_report.Text = atm.reportMoney(checkCardNumber); //печать справки об остатке по счету
        }
    }
}
