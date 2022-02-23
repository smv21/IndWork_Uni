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

        ATM atm; //��������
        int checkCardNumber; //�������� ����� �����
        int trycounter = 0; //���������� �������
        int operation; //��� �������� ( 0 - ������ ��������, 1 - ������ ������� �� �����)

        private void Form1_Load(object sender, EventArgs e)
        {
            atm = new ATM(); //������� ������ ���������
        }

        private void button_checknumber_Click(object sender, EventArgs e) //���� �� ������ "���� �����"
        {
             //������ ������������ ��������� �������� � ���������� ������
            button_cash.Enabled = false;
            button_money.Enabled = false;
            button_payment.Enabled = false;
            button_reportmoney.Enabled = false;
            button_sum.Enabled = false;
            textBox_sum.Enabled = false;
            checkBox_report.Enabled = false;
            label_sum.Text = "������� ����� �����";
            label_report.Text = "";

            checkCardNumber = Convert.ToInt32(textBox_cardnumber.Text); //��������� ����� ����� �� ����������
            if (atm.checkBlocked(checkCardNumber)) //���� ����� ������� � ��������� ��������������� ����
            {
                label_info.Text = "����� �������������.";
                button_checkpincode.Enabled = false;
                textBox_pincode.Enabled = false;
            }
            else //���� ����� �� � ��������� ��������������� ����
            {
                if (atm.checkNumber(checkCardNumber)) //���� ����� ���� � ������ ����
                {
                    textBox_pincode.Enabled = true;
                    button_checkpincode.Enabled = true;
                    label_info.Text = "����� �������.";
                    label_pincodeinfo.Text = "������� ���-���";
                }
                else //���� ����� ��� � ������ ����
                {
                    label_info.Text = "����� ����� ��������";
                }
            }
            label_counter.Text = "";
        }

        private void button_checkpincode_Click(object sender, EventArgs e) //���� �� ������ "������ ���"
        {
            int checkPinCode = Convert.ToInt32(textBox_pincode.Text); //��������� ��� �� ���������
            bool correctPin = atm.checkPincode(checkPinCode, checkCardNumber);
            if (correctPin) //���� ��� ����������
            {
                label_pincodeinfo.Text = "������ ������";
                label_counter.Text = "";
                button_cash.Enabled = true;
                button_money.Enabled = true;
                button_payment.Enabled = true;
            }
            else //���� ��� ������������
            {
                label_pincodeinfo.Text = "���-��� ��������";
                button_cash.Enabled = false;
                button_money.Enabled = false;
                button_payment.Enabled = false;
                button_reportmoney.Enabled = false;
                button_sum.Enabled = false;
                textBox_sum.Enabled = false;
                label_sum.Text = "������� ����� �����";
                label_report.Text = "";
            }

            if (!correctPin && trycounter <= 2) //���� ������� ������ ��� ����� ����
            {
                trycounter++; //����������� ����� �������
                label_counter.Text = "�������� �������: " + (3 - trycounter);
            }
            if (!correctPin && trycounter == 3) //���� ���������� ������� ��� ����� 3
            {
                label_counter.Text = "����� �������������"; 
                button_checkpincode.Enabled = false;
                textBox_pincode.Enabled = false;
                atm.blockAccount(checkCardNumber); //��������� ����� � ������ ��������������� � ���������� ��
            }
        }

        private void button_cash_Click(object sender, EventArgs e)  //���� �� ������ "����� ��������"
        {
            checkBox_report.Enabled = true;
            textBox_sum.Enabled = true;
            button_sum.Enabled = true;
            operation = 0; //������ ��� ������� �������� �� ������ ��������
        }

        private void button_money_Click(object sender, EventArgs e)   //���� �� ������ "������ ������� �� �����"
        {
            label_display.Text = "�� �����: " + atm.balance(checkCardNumber).ToString(); //������� ������ ����� �� �������
            button_reportmoney.Enabled = true;
        }

        private void button_payment_Click(object sender, EventArgs e)   //���� �� ������ "����������� ������"
        {
            textBox_sum.Enabled = true;
            button_sum.Enabled = true;
            operation = 1; //������ ��� ������� �������� �� ������ ��������
        }

        private void button_sum_Click(object sender, EventArgs e)   //���� �� ������ "������ �����"
        {
            int sum = Convert.ToInt32(textBox_sum.Text); //��������� ����� �� ����������
            if (operation == 0) //���� �� ����� ������� �������� ������ ��������
            {
                if(atm.checkMoney(checkCardNumber, sum)) //���� �� ����� ������� �������� ��� ������
                {
                    if(atm.giveMoney(checkCardNumber, sum)) //���� � ��������� ������� ����� � �������� ������ �������
                    {
                        label_sum.Text = "������ �������� ������ �������";
                        label_display.Text = "������ �����";

                        if(checkBox_report.Checked) //���� ������� ������ �������
                        {
                            label_report.Text = atm.reportCash(checkCardNumber, sum); //������ ������� �� ������ ��������
                        }
                    }
                    else //���� � ��������� �� ������� �����
                    {
                        label_sum.Text = "�������� �� ����� ������ ��� �����";
                    }
                }
                else //���� �� ����� �� ���������� ������� ��� ������
                {
                    label_sum.Text = "������������ ������� �� �����";
                }
            }
            else if(operation == 1) //���� �� ����� ������� �������� ��������
            {
                if (atm.payment(checkCardNumber, sum)) //���� �������� ������������ �������� ������ �������
                {
                    label_sum.Text = "����� ����������";
                }
                else  //���� �������� ������������ �������� ������ �� �������
                {
                    label_sum.Text = "������������ ������� �� �����";
                }
            }
        }

        private void button_reportmoney_Click(object sender, EventArgs e)   //���� �� ������ "���������� ������� �� ������� �� �����"
        {
            label_report.Text = atm.reportMoney(checkCardNumber); //������ ������� �� ������� �� �����
        }
    }
}
