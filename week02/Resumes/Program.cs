using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();

        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume resume = new Resume();

        resume._name = "Renan Campos";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
        
    }
}