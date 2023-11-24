namespace Labb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           //Här matar vi namn och åldern på personerna och det skrevs ut i konsolet
            Console.WriteLine("Skriv namnet på person 1");
            string Name1=Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 1");
            int Age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv namnet på person 2");
            string Name2 = Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 2");
            int Age2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv namnet på person 3");
            string Name3= Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 3");
            int Age3= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv namnet på person 4");
            string Name4=Console.ReadLine();
            Console.WriteLine("Skriv åldern på person 4");
            int Age4= Convert.ToInt32(Console.ReadLine());
            //Här skrivs det ut namnen och åldrarna som användaren har valt
            Console.WriteLine(Name1 + " är " + Age1 + "år gammal.");
            Console.WriteLine(Name2 + " är " + Age2 + "år gammal.");
            Console.WriteLine(Name3 + " är " + Age3 + "år gammal.");
            Console.WriteLine(Name4 + " är " + Age4 + "år gammal.");
            //Här räknar vi ut totala åldern plus medelvärdet på åldrarna 
            int Total = Age1 + Age2 + Age3 + Age4;
            Console.WriteLine("Sammanlagd ålder är:" + Total);
            double AverageValue = (double)Total / 4;
            string Deci = AverageValue.ToString("0.00");
            Console.WriteLine("Medelvärdet är:" + Deci );


        }
    }
}