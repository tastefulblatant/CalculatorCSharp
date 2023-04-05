namespace Calculator
{

        internal class Program
        {
            static void Main(string[] args)
            {


                int i1, i2;


                Console.WriteLine("Zadejte první číslo: ");
                i1 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Zadejte druhé číslo: ");
                i2 = int.Parse(Console.ReadLine());


                Console.WriteLine();
                Console.WriteLine("Zadejte operaci: * pro násobení, / pro dělení, + pro sčítání, - pro odčítání: ");
                string operation = Console.ReadLine();


                switch (operation)
                {
                    case "+":
                        Console.WriteLine(i1 + i2);
                        break;

                    case "-":
                        Console.WriteLine(i1 - i2);
                        break;

                    case "*":
                        Console.WriteLine(i1 * i2);
                        break;
                    case "/":
                        if (i2 != 0)
                            Console.WriteLine(i1 / i2);
                        else
                            Console.WriteLine("Druhé číslo nesmí být nula.");
                        break;


                    default:
                        Console.WriteLine("Nebyla zadána ani jedna platná operace. ");
                        break;
                }




            }
        }
}
