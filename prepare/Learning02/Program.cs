using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2005;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Receptionist";
        job2._company = "Dunder Mifflin";
        job2._startYear = 2003;
        job2._endYear = 2005;

        Resume resume1 = new Resume();
        resume1._name = "Sarah Glenn";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}