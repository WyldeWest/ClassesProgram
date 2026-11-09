using System.IO.Pipes;

class Program
{

    static void DisplayPersonInformation(Person person)
    {
        if (person is Doctor d)
        {
            Console.WriteLine(d.GetDoctorInfromation());
        }
        else if(person is Police p)
        {
            Console.WriteLine(p.GetPoliceInformation());
        }
        else
        {
           Console.WriteLine(person.GetPersonInformation()); 
        }
    }
    static void Main()
    {
        Person myPerson = new Person("Bob", "Floyd", 56, 141.23);

        //myPerson.GetPersonInformation();
        //Console.WriteLine(myPerson.GetPersonInformation());

        Police myPolice = new Police("Lance", "Bob", 34, 186, "Taser");

        //myPolice.GetPersonInformation();
        //Console.WriteLine(myPolice.GetPoliceInfromation());

        Doctor myDoctor = new Doctor("Billy", "Payne", 20, 150, "knife");
        //Console.WriteLine(myDoctor.GetDoctorInfromation());


        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);
    }
}
