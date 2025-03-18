class Policeman : Person
{
    private string _weapon;
    public Policeman(string weapon, string firstName, string lastName, int age) 
    : base(firstName, lastName, age)
    {
        _weapon = weapon;
    }
    public string DisplaypolicManInfo()
    {
        return $"{_weapon}, Info: {DisplayPersonInfo()}";
    }
}