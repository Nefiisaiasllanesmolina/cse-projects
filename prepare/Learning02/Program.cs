using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Project Manager";
        job1._startYear = 2001;
        job1._endYear = 2011;
        /*job1.Display();*/

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2011;
        job2._endYear = 2022;
        /*job2.Display();*/

        Resume resume1 = new Resume();
        resume1._name = "Nefi Llanes";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

        Resume resume2 = new Resume();
        resume2._name = "Cosqui";
        resume2._jobs.Add(job1);
        resume2._jobs.Add(job2);

        
    }
}