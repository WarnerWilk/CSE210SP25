using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job myFirstJob = new Job("Taco Time", "CEO", 2020, 2022);
        Job mySecondJob = new Job("Domino's", "Customer Service Representative", 2017, 2020);

        Resume myResume = new Resume("Bob Bobba");
        myResume.AddJob(myFirstJob);
        myResume.AddJob(mySecondJob);
        myResume.DisplayResume();
    }
}
// I already did this assignment previously.