using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise> {};

        Running run = new Running("01 Apr 2024", 30, 2);
        exercises.Add(run);

        Bike bike = new Bike("01 Apr 2024", 60, 10);
        exercises.Add(bike);

        Swimming swim = new Swimming("01 Apr 2024", 30, 50);
        exercises.Add(swim);

        foreach (Exercise e in exercises)
        {
            e.GetSummary();
        }

    }
}