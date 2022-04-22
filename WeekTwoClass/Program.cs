using System;

namespace WeekTwoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Built-in types
            //Type conversions
            //Nullable types
            //Anonymous types
            //Dynamic types
            //Variables in C#

            //<data type> <name of variable> = <Value>

            //string myName = "Adebayo Abdul Qohar Qoharant";
            // int myage = 20;
            //double nairaTodollar = 570.23;
            //int nairaTodollarint = (int)nairaTodollar;
            //float a = myage;
            //long b = myage; 

            //double nairaToEuro = 680.58;
            //int nairaToEuroint = (int)nairaToEuro; 
            //var myName = "Adebayo Abdul Qohar";
            //var myAge = 20;
            //var nairaToEuro =  680.58;

            var anonTypes = new {name = "anonymous", 
            project = "Dotnet", 
            version = 5.0};          
            



            Console.WriteLine("Hello World!");
            //Console.WriteLine(myName);
            //Console.WriteLine(myage);
            //Console.WriteLine(nairaTodollarint);
            //Console.WriteLine(nairaToEuroint);
            //Console.WriteLine(myage);
            //Console.WriteLine(myage);

            //Console.WriteLine(myName);
            //Console.WriteLine(myAge);
            //Console.WriteLine(nairaToEuro);

            Console.WriteLine(anonTypes);
             //dot notation
            Console.WriteLine(anonTypes.name);
            Console.WriteLine(anonTypes.project);
            Console.WriteLine(anonTypes.version);



           

            

            
        }
    }
}
