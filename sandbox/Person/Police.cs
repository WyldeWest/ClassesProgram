class Police : Person
{
    private string _weapons;
 
    public Police(string firstName, string lastName, int age, double weight, string weapons) 
    : base(firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public string GetPoliceInfromation()
    {
        return $"Police: {GetPersonInformation()} Weapons: {_weapons}";
    }
}