using System.IO.Pipes;

class Program
{
    static void Main()
    {
        Person myPerson = new Person("Bob", "Floyd", 56, 141.23);

        myPerson.GetPersonInformation();
        Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Lance", "Bob", 34, 186, "Taser");

        myPolice.GetPersonInformation();
        Console.WriteLine(myPolice.GetPoliceInfromation());

        Doctor myDoctor = new Doctor("Billy", "Payne", 20, 150, "knife");
        Console.WriteLine(myDoctor.GetDoctorInfromation());
    }
}
