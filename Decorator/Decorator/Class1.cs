using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Component
    {
        public abstract string GetInfo();
    }


    class ConcreteComponent : Component
    {
        public override string GetInfo()
        {
            return "Запрашиваемая информация: ";
        }
    }


    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override string GetInfo()
        {
            if (component != null)
            {
                return component.GetInfo();
            }
            return "";    
        }
    }


    class Passport : Decorator
    {
        int series;
        int number;
        string fullName;
        DateTime birthday;

        public Passport(int series, int number, string fullName, DateTime birthday)
        {
            this.series = series;
            this.number = number;
            this.fullName = fullName;
            this.birthday = birthday;
        }

        public override string GetInfo()
        {
            string previous = base.GetInfo();

            return previous + "\n\tПасспорт:" +
                "\n\t\tСерия: " + series +
                "\n\t\tНомер: " + number  +
                "\n\t\tФИО: " + fullName +
                "\n\t\tДень рождения: " + birthday.ToShortDateString();
        }
    }


    class Insurance : Decorator
    {
        string number;
        string fullName;
        DateTime birthday;

        public Insurance(string number, string fullName, DateTime birthday)
        {
            this.number = number;
            this.fullName = fullName;
            this.birthday = birthday;
        }

        public override string GetInfo()
        {
            string previous = base.GetInfo();

            return previous + "\n\tСНИЛС:" +
                "\n\t\tНомер: " + number +
                "\n\t\tФИО: " + fullName +
                "\n\t\tДень рождения: " + birthday.ToShortDateString();
        }
    }

    class BankCard : Decorator
    {
        string number;
        DateTime validDate;
        string name;
        string paymentSystem;

        public BankCard(string number, string name, DateTime validDate, string paymentSystem)
        {
            this.number = number;
            this.name = name;
            this.validDate = validDate;
            this.paymentSystem = paymentSystem;
        }

        public override string GetInfo()
        {
            string previous = base.GetInfo();

            return previous + "\n\tБанковская карта:" +
                "\n\t\tНомер: " + number +
                "\n\t\tДейстивтельна до: " + validDate.ToString("MM/yy") +
                "\n\t\tИмя: " + name +
                "\n\t\tПлатежная система: " + paymentSystem;
        }
    }
}
