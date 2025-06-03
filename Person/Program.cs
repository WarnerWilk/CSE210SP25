class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bubba", "Bob", 53);
        Console.WriteLine(myPerson.GetPersonInformation());
    }
}