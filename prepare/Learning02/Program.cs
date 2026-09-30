using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Daytime Custodian";
        job1._company = "BYU-I";
        job1._startYear = 2026;
        job1._endYear = 2027;

        Job job2 = new Job();
        job2._jobTitle = "Laborer";
        job2._company = "BFC Construction";
        job2._startYear = 2023;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Marshall West";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}