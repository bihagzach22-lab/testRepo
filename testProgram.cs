using System.Globalization;

internal class testProgram
{
    private static void Main(string[] args)
    {
        Person p = new Person();

        p.display("zach",19);
        


        Console.ReadKey();
    }

    class Person()
    {
        public string name { get; set; }
        public int age { get; set; }

        public void display(string name, int age)
        {
            int year = 2025;

            for (int i = age; i <= 27; i++)
            {
                Console.WriteLine($"i am {name} and  i am {i} years old in {year}");
                year++;
            }
        }
    }
   
}