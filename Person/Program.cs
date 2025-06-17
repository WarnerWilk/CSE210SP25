class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bubba", "Bob", 53);

        // Console.WriteLine(myPerson.GetPersonInformation());

        Policeman myPoliceman = new Policeman("Steves", "Cooper", 30, "Gun", 50000);
        // Console.WriteLine(myPoliceman.GetPoliceInformation());

        Doctor theDoctor = new Doctor("Smith", "John", 906, "Sonic Screwdriver", 0);
        // Console.WriteLine(theDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myPoliceman);
        myPeople.Add(theDoctor);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
            
        }
    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.Write(person.GetPersonInformation());
        Console.Write($" Salary: {person.GetSalary()}\n");
    }
}