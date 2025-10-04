namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student denis = new Student();
            Console.WriteLine(denis);
            denis.name = "Denis";
            denis.age = 18;
            denis.group = "ISP-231";
            denis.PrintInfo();
            Student neighboor = new Student();
            Console.Write("Введите имя: ");
            neighboor.name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            neighboor.age = int.Parse(Console.ReadLine());
            Console.Write("Введите группу: ");
            neighboor.group = Console.ReadLine();
            neighboor.PrintInfo();
            Console.WriteLine($"Студент {neighboor.name} совершеннолетний - {neighboor.IsAdult()}");

            Car myCar = new Car();

            myCar.model = "Toyota";
            Console.WriteLine($"Модель: {myCar.model}");

            myCar.Accelerate(20);

            Player player = new Player();
            player.TakeDamage(34);
            Console.WriteLine(player.GetHealth());

            Television tv = new Television();
            tv.SetVolume(50);
            tv.SetVolume(150);

            BankAccount bankAccount = new BankAccount();
            bankAccount.Deposit(50);
            bankAccount.Withdraw(23);

            Student anton = new();
            anton.PrintInfo();

            Student maksim = new Student("Anton");

            Person bob = new(68);
            bob.CheckAge();
            Person tom = new(37);
            tom.CheckAge();
            Console.WriteLine(Person.retirementAge);
            Person.retirementAge = 67;

            //PickRandomCards
            Console.Write("Введите количество карт для выбора: ");
            string? line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards)) {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards)) {
                    Console.WriteLine(card);
                }
            } else {
                Console.WriteLine("Введите корректное число.");
            }
        }
    }
}