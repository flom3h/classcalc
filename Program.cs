namespace classcalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechnung rechnung1 = new Rechnung(100, 20);

            Console.WriteLine($"{rechnung1}");

            while(true)
            {
                string opt = PrintMenu1();
                try
                {
                    if (opt == "y")
                    {
                        string Prozent = PrintMenu2();
                        Prozent = Prozent.ToDouble();
                        rechnung1.PrintRabatt((double)Prozent);
                    }
                    else if (opt == "n")
                    {
                        rechnung1.PrintBruttopreis();
                        rechnung1.PrintNettopreis();
                    }
                }

                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        static string PrintMenu1()
        {
            string menu = @"
Möchtest du einen Rabatt auf deine Rechnung haben?
y: 
n: ";
            Console.WriteLine(menu);

            string SelectedOption;

            do
            {
                Console.Write("Deine Wahl: ");
                SelectedOption = Console.ReadLine();
            } while (SelectedOption != "y" && SelectedOption != "n");
            return SelectedOption;
        }

        static string PrintMenu2() 
        {
            string menu = @"
Wie viel Rabatt möchtest du haben?
5:
10:
20: ";
            Console.WriteLine(menu);
            string chosendiscount;
            do
            {
                Console.Write("Deine Wahl: ");
                chosendiscount = Console.ReadLine();
            } while (chosendiscount != "5" && chosendiscount != "10" && chosendiscount != "20");
            return chosendiscount;
        }
    }
}
