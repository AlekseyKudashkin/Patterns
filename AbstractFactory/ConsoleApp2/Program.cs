using System;
using System.Xml.Schema;

namespace ConsoleApp2
{
    class MainApp
    { 
        public static void Main()
        {
                Console.WriteLine("Добро пожаловать в абстрактную фабрику!\n" +
                    "Какую марку вы предпочитаете?\n" +
                    "1) Ваз\n" +
                    "2) KIA\n" +
                    "3) Toyota\n" +
                    "Введите соответсующую цифру и нажмите Enter...");


            int factoryType;
            for (; ; )
            {
                try
                {
                    factoryType = Convert.ToInt32(Console.ReadLine());
                    if (factoryType != 1 && factoryType != 2 && factoryType != 3)
                        Console.WriteLine("\nВы выбрали неверную позицию!\nПовторите попытку...\n");
                    else
                        break;
                }
                catch
                {
                     Console.WriteLine("\nВы выбрали неверную позицию!\nПовторите попытку...\n");
                }
            }


            Console.WriteLine(
                    "\nЧто хотите приобрести?\n" +
                    "1) Джип\n" +
                    "2) Легковой автомобиль\n" +
                    "Введите соответсующую цифру и нажмите Enter...");

            int productType;
            for (; ; )
            {
                try
                {
                    productType = Convert.ToInt32(Console.ReadLine());
                    if (productType != 1 && productType != 2)
                        Console.WriteLine("\nВы выбрали неверную позицию!\nПовторите попытку...\n");
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("\nВы выбрали неверную позицию!\nПовторите попытку...\n");
                }
            }


            Client client;
            if (factoryType == 1)
                client = new Client(new AutoVAZ());
            else if (factoryType == 2)
                client = new Client(new KiaMotors());
            else
                client = new Client(new Toyota());

            Console.WriteLine("\nДанные о выбранной модели:");
            client.Run(productType);

            Console.ReadKey();
        }
    }


    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreatePassengers();
        public abstract AbstractProductB CreateJeep();
    }


    
    class AutoVAZ : AbstractFactory
    {
        public override AbstractProductA CreatePassengers()
        {
            return new VazPassengers("LADA XRAY", "Серая", 78);
        }
        public override AbstractProductB CreateJeep()
        {
            return new VazJeep("LADA Niva", "Синяя", 73);
        }
    }


    class Toyota : AbstractFactory
    {
        public override AbstractProductA CreatePassengers()
        {
            return new ToyotaPassengers("Toyota Corolla", "Красная", 101);
        }
        public override AbstractProductB CreateJeep()
        {
            return new ToyotaJeep("Toyota Land Cruiser 200", "Черная", 190);
        }
    }


    class KiaMotors : AbstractFactory
    {
        public override AbstractProductA CreatePassengers()
        {
            return new KiaPassengers("KIA Rio", "Белая", 80);
        }
        public override AbstractProductB CreateJeep()
        {
            return new KiaJeep("KIA Rio X-Line", "Бронзовая", 90);
        }
    }


    abstract class AbstractProductA
    {
        public string model;
        public string color;
        public int horsepower;

        public abstract void getName();
        public abstract void getSpec();
    }


    abstract class AbstractProductB
    {
        public string model;
        public string color;
        public int horsepower;

        public abstract void getName();
        public abstract void getSpec();
    }

    class ToyotaPassengers : AbstractProductA
    {
        public ToyotaPassengers(string _model, string _color, int _horsepower)
        {
            this.model = _model;
            this.color = _color;
            this.horsepower = _horsepower;
        }

        public override void getName()
        {
            Console.WriteLine("Легковой автомобиль Toyota");
        }
        public override void getSpec()
        {
            Console.WriteLine("Спецификация:\n" +
                $"Модель: {this.model}\n" +
                $"Цвет: {this.color}\n" +
                $"Лошадиные силы: { this.horsepower}\n");
        }

    }


    class ToyotaJeep : AbstractProductB
    {
        public ToyotaJeep(string _model, string _color, int _horsepower)
        {
            this.model = _model;
            this.color = _color;
            this.horsepower = _horsepower;
        }

        public override void getName()
        {
            Console.WriteLine("Джип Toyota");
        }

        public override void getSpec()
        {
            Console.WriteLine("Спецификация:\n" +
                $"Модель: {this.model}\n" +
                $"Цвет: {this.color}\n" +
                $"Лошадиные силы: { this.horsepower}\n");
        }
    }


    class VazPassengers : AbstractProductA
    {
        public VazPassengers(string _model, string _color, int _horsepower)
        {
            this.model = _model;
            this.color = _color;
            this.horsepower = _horsepower;
        }

        public override void getName()
        {
            Console.WriteLine("Легковой автомобиль ВАЗ");
        }
        public override void getSpec()
        {
            Console.WriteLine("Спецификация:\n" +
                $"Модель: {this.model}\n" +
                $"Цвет: {this.color}\n" +
                $"Лошадиные силы: { this.horsepower}\n");
        }

    }


    class VazJeep : AbstractProductB
    {
        public VazJeep(string _model, string _color, int _horsepower)
        {
            this.model = _model;
            this.color = _color;
            this.horsepower = _horsepower;
        }

        public override void getName()
        {
            Console.WriteLine("Джип ВАЗ");
        }

        public override void getSpec()
        {
            Console.WriteLine("Спецификация:\n" +
                $"Модель: {this.model}\n" +
                $"Цвет: {this.color}\n" +
                $"Лошадиные силы: { this.horsepower}\n");
        }
    }


    class KiaPassengers : AbstractProductA
    {
        public KiaPassengers(string _model, string _color, int _horsepower)
        {
            this.model = _model;
            this.color = _color;
            this.horsepower = _horsepower;
        }

        public override void getName()
        {
            Console.WriteLine("Легковой автомобиль KIA");
        }

        public override void getSpec()
        {
            Console.WriteLine("Спецификация:\n" +
                $"Модель: {this.model}\n" +
                $"Цвет: {this.color}\n" +
                $"Лошадиные силы: { this.horsepower}\n");
        }
    }


    class KiaJeep : AbstractProductB
    {
        public KiaJeep(string _model, string _color, int _horsepower)
        {
            this.model = _model;
            this.color = _color;
            this.horsepower = _horsepower;
        }

        public override void getName()
        {
            Console.WriteLine("Джип KIA");
        }

        public override void getSpec()
        {
            Console.WriteLine("Спецификация:\n" +
                $"Модель: {this.model}\n" +
                $"Цвет: {this.color}\n" +
                $"Лошадиные силы: { this.horsepower}\n");
        }
    }


    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateJeep();
            _abstractProductA = factory.CreatePassengers();
        }

        public void Run(int factoryType)
        {
            if (factoryType == 1) {
                _abstractProductB.getName();
                _abstractProductB.getSpec();
            }
            else {
                _abstractProductA.getName();
                _abstractProductA.getSpec();
            }
        }

    }
}
