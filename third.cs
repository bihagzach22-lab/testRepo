internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();   

        Console.WriteLine("age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Hi {name} good day");
        if(age < 18)
        {
            Console.WriteLine("minor");
        }
        else
        {
            Console.WriteLine("ADult");
        }


        for(int i= 1;i <= age; i++)
        {
            Console.WriteLine(i);
        }


        Console.WriteLine($"birth day:{getBirth(age)}");
       


    }
    public static int getBirth(int age)
    {
        return 2025 - age;
    }

}