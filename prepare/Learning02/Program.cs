using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1991;
        job1._endYear = 2084;

        Job job2 = new Job();
        job2._jobTitle = "Product Designer";
        job2._company = "Apple";
        job2._startYear = 1989;
        job2._endYear = 2079;

        Resume resume1 = new Resume();

        resume1._name = "John Doe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}