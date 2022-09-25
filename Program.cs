class assignment
{
    static void Main(string[] args)
    {
        // ------First Problem----
        // C# , F# და Visual Basic Code კომპილირდება -> C# compiler, F# compier და visual code Compiler.
        // კომპილაციის შემდეგ სამივე მათგანი გარდაიქმნება CIL , შემდეგ CLR-ად 
        // და ბოლოს მანქანურ ენად , ჩიწერება ორობით სისტემაში , 0-ით და 1-ით.



        Console.WriteLine("----------Second Problem ----------");

        Console.Write("Enter first number: "); ;
        string fnum = Console.ReadLine();
        Console.Write("Enter second number: ");
        string snum = Console.ReadLine();

        bool fIsDouble = double.TryParse(fnum, out double res);
        bool sIsDouble = double.TryParse(snum, out double res1);

        if (fIsDouble && sIsDouble)
        {

            Console.WriteLine($"sum is:{res + res1}");
            Console.WriteLine($"subrance is:{res - res1}");
            Console.WriteLine($"multiple is:{res * res1}");
        }
        else if (!fIsDouble)
        {
            Console.WriteLine($"{fnum} : is not number");
        }
        else if (!sIsDouble)
        {
            Console.WriteLine($"{snum} : is not number");
        }
        else
        {
            Console.WriteLine($"{fnum} and {snum} : is not number");

        }

        Console.WriteLine("----------Third Problem ----------");

        Console.Write("Enter rectangle length number: "); ;
        string l = Console.ReadLine();
        Console.Write("Enter rectangle height number: ");
        string h = Console.ReadLine();

        bool recLength = int.TryParse(l, out int result);
        bool recHeight = int.TryParse(h, out int result1);

        if (recLength && recHeight)
        {

            Console.WriteLine($"perimetre is:{2 * result + 2 * result1}");
            Console.WriteLine($"area is:{result * result1}");
        }
        else if (!recLength)
        {
            Console.WriteLine($"{l} : is not number");
        }
        else if (!recHeight)
        {
            Console.WriteLine($"{h} : is not number");
        }
        else
        {
            Console.WriteLine($"{l} and {h} : is not number");
        }


        Console.WriteLine("----------Fourth Problem ----------");

           Console.WriteLine("Enter first number: "); ;
           string num1 = Console.ReadLine();
           Console.WriteLine("Enter second number: ");
           string num2 = Console.ReadLine();
           Console.WriteLine("Enter third number: "); ;
           string num3 = Console.ReadLine();
           Console.WriteLine("Enter second number: ");

           bool isNum1 = int.TryParse(num1, out int resnum1);
           bool isNum2 = int.TryParse(num2, out int resnum2);
           bool isNum3 = int.TryParse(num3, out int resnum3);

           if(isNum1 && isNum2 && isNum3)
           {

           }
          

      


        Console.WriteLine("----------Fifth Problem ----------");

        Console.WriteLine("enter tree digitaln number");

        int num5 = int.Parse(Console.ReadLine());
        int f1 = num5 / 100;
        int f2 = (num5 / 10) % 10;
        int f3 =  num5 % 10; ;
        Console.WriteLine($"First number is : {f1}");
        Console.WriteLine($"Second number is : {f2}");
        Console.WriteLine($"Third number is : {f3}");
    }



}
    

