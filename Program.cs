class Program
{
    int menucheck = 1;
    int counter;
    string pass = "pass123";
    double money;
    int teawithmilkandsugar, teawithmilk, teawithsugar, coffeecounter;
    int cups = 10, coffee = 10, milk = 10, sugar = 10, tea = 10;
    static public void Main()
    {
        Program obj = new Program();
        obj.menu();
    }
    public void menu()
    {
        Program obj1 = new Program();
        Console.WriteLine("1. Tea with sugar and milk");
        Console.WriteLine("2. Tea with milk");
        Console.WriteLine("3. Tea with sugar");
        Console.WriteLine("4. Coffee");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Admin mode(Extension)");
        Console.WriteLine("7. Secret option(Extension)");
        Console.Write("Enter what do you want to do: ");
        while (menucheck >= 1 && menucheck <= 6)
        {
            try
            {
                obj1.menucheck = int.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Invalid input. ");
            }
        }
        switch (obj1.menucheck)
        {
            case 1:
                cups--;
                tea--;
                sugar--;
                milk--;
                if (cups <= 0)
                {
                    Console.WriteLine("Sorry, I cannot complete your order because we do not have cups!");
                    if (tea <= 10)
                    {
                        Console.WriteLine("I am also cannot complete your order because we do not have enough tea!");
                    }
                    else if (sugar <= 10)
                    {
                        Console.WriteLine("I am also cannot complete your order because we do not have enough sugar!");
                    }
                    else if (milk <= 10)
                    {
                        Console.WriteLine("I am also cannot complete your order because we do not have enough milk!");
                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You have ordered tea with sugar with milk ");
                    money += 15;
                    teawithmilkandsugar++;
                    obj1.makingdrink();
                    Console.WriteLine("I already made " + teawithmilkandsugar + " teas with milk and with sugar!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                menu();
                break;
            case 2:
                cups--;
                tea--;
                milk--;
                if (cups <= 0)
                {
                    Console.WriteLine("Sorry, I cannot complete your order because we do not have cups!");
                    if (tea <= 10)
                    {
                        Console.WriteLine("I am also cannot complete your order because we do not have enough tea!");
                    }
                    else if (milk <= 10)
                    {
                        Console.WriteLine("I am also cannot complete your order because we do not have enough milk!");
                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You have ordered tea with milk ");
                    money += 13;
                    teawithmilk++;
                    obj1.makingdrink();
                    Console.WriteLine("I already made " + teawithmilk + " teas with milk!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                menu();
                break;
            case 3:
                cups--;
                tea--;
                sugar--;
                if (cups <= 0)
                {
                    Console.WriteLine("Sorry, I cannot complete your order because we do not have cups!");
                    if (tea <= 10)
                    {
                        Console.WriteLine("I am also cannot complete your order because we do not have enough tea!");
                    }
                    else if (sugar <= 10)
                    {
                        Console.WriteLine("I am also cannot complete your order because we do not have enough sugar!");
                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You have ordered tea with sugar ");
                    money += 11;
                    teawithsugar++;
                    obj1.makingdrink();
                    Console.WriteLine("I already made " + teawithsugar + " teas with sugar!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                menu();
                break;
            case 4:
                cups--;
                coffee--;
                if (cups <= 0)
                {
                    Console.WriteLine("Sorry, I cannot complete your order because we do not have cups!");
                    if (coffee <= 10)
                    {
                        Console.WriteLine("I am also cannot complete your order because we do not have enough coffee!");
                    }
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You have ordered coffee");
                    money += 7;
                    coffeecounter++;
                    obj1.makingdrink();
                    Console.WriteLine("I already made " + coffeecounter + " coffees!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                menu();
                break;
            case 5:
                break;
            case 6:
                passwordcheck();
                Console.WriteLine("I have earned " + money + "£!");
                Thread.Sleep(2000);
                Console.Clear();
                menu();
                break;
            case 7:
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("░░░░░░░░░░▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄░░░░░░░░░");
                Console.WriteLine("░░░░░░░░▄▀░░░░░░░░░░░░▄░░░░░░░▀▄░░░░░░░");
                Console.WriteLine("░░░░░░░░█░░▄░░░░▄░░░░░░░░░░░░░░█░░░░░░░");
                Console.WriteLine("░░░░░░░░█░░░░░░░░░░░░▄█▄▄░░▄░░░█░▄▄▄░░░");
                Console.WriteLine("░▄▄▄▄▄░░█░░░░░░▀░░░░▀█░░▀▄░░░░░█▀▀░██░░");
                Console.WriteLine("░██▄▀██▄█░░░▄░░░░░░░██░░░░▀▀▀▀▀░░░░██░░");
                Console.WriteLine("░░▀██▄▀██░░░░░░░░▀░██▀░░░░░░░░░░░░░▀██░");
                Console.WriteLine("░░░░▀████░▀░░░░▄░░░██░░░▄█░░░░▄░▄█░░██░");
                Console.WriteLine("░░░░░░░▀█░░░░▄░░░░░██░░░░▄░░░▄░░▄░░░██░");
                Console.WriteLine("░░░░░░░▄█▄░░░░░░░░░░░▀▄░░▀▀▀▀▀▀▀▀░░▄▀░░");
                Console.WriteLine("░░░░░░█▀▀█████████▀▀▀▀████████████▀░░░░");
                Console.WriteLine("░░░░░░████▀░░███▀░░░░░░▀███░░▀██▀░░░░░░");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Thread.Sleep(100);
                Console.Clear();
                menu();
                break;
        }
    }

    public void makingdrink()
    {
        Console.WriteLine("I am making your drink, you need to wait a bit:");
        Thread.Sleep(1000);
        Console.WriteLine("3...");
        Thread.Sleep(1000);
        Console.WriteLine("2...");
        Thread.Sleep(1000);
        Console.WriteLine("1...");
        Thread.Sleep(1000);
        Console.WriteLine("Your dring is ready, enjoy) ");
    }

    public void passwordcheck()
    {
        Console.Write("Please enter your password: ");
        string enteredPass = Convert.ToString(Console.ReadLine());
        while ((pass != enteredPass) && (counter !=2))
        {

            Console.Write("Your password is wrong! Try again: ");
            enteredPass = Convert.ToString(Console.ReadLine());
            counter++;
        }
        if (counter == 2)
        {
            Console.Clear();
            menu();
        }
    }
}