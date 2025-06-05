class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bubba", "Bob", 53);

        Console.WriteLine(myPerson.GetPersonInformation());

        Policeman myPoliceman = new Policeman("Steves", "Cooper", 30, "Gun");
        Console.WriteLine(myPoliceman.GetPoliceInformation());

        Doctor theDoctor = new Doctor("Smith", "John", 906, "Sonic Screwdriver");
        Console.WriteLine(theDoctor.GetDoctorInformation());
    }
}