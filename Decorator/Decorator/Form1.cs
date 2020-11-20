using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        ConcreteComponent comp = new ConcreteComponent();
        Passport passport = new Passport(8919, 506576, "Кудашкин Алексей Евгеньевич", new DateTime(1999, 4, 22));
        Insurance insurance = new Insurance("129-436-436 82", "Кудашкин Алексей Евгеньевич", new DateTime(1999, 4, 22));
        BankCard bankCard = new BankCard("4276 3900 1927 0135", "KUDASHKIN ALEKSEI", new DateTime(2020, 10, 30), "VISA");

        public Form1()
        {
            InitializeComponent();
            passport.SetComponent(comp);
            insurance.SetComponent(passport);
            bankCard.SetComponent(insurance);
            Console.WriteLine(bankCard.GetInfo());
        }
      

        private void DisplayInfo()
        {
            if (passportCheckBox.Checked)
            {
                passport.SetComponent(comp);
                if (insuranceCheckBox.Checked)
                {
                    insurance.SetComponent(passport);
                    if (bankCardCheckBox.Checked)
                    {
                        bankCard.SetComponent(insurance);
                        richTextBox1.Text = bankCard.GetInfo();
                    }
                    else
                    {
                        richTextBox1.Text = insurance.GetInfo();
                    }
                }
                else if (bankCardCheckBox.Checked)
                {
                    bankCard.SetComponent(passport);
                    richTextBox1.Text = bankCard.GetInfo();
                }
                else
                {
                    richTextBox1.Text = passport.GetInfo();
                }
            }
            else if (insuranceCheckBox.Checked)
            {
                insurance.SetComponent(comp);
                if (bankCardCheckBox.Checked)
                {
                    bankCard.SetComponent(insurance);
                    richTextBox1.Text = bankCard.GetInfo();
                }
                else
                {
                    richTextBox1.Text = insurance.GetInfo();
                }
            }
            else if (bankCardCheckBox.Checked)
            {
                bankCard.SetComponent(comp);
                richTextBox1.Text = bankCard.GetInfo();
            }
            else
            {
                richTextBox1.Text = "Информация не запрошена.";
            }
        }


        private void passportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayInfo();
        }


        private void insuranceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        private void bankCardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayInfo();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
