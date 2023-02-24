using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Electrical Engineer";
        job1._company = "Tesla";
        job1._startYear = 2016;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._jobTitle = "Tech 1";
        job2._company = "sewage facory";
        job2._startYear = 2017;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Nathan Wight";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
