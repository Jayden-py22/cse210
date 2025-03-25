class Policeman : Person
{
    private string _weapon;
    public Policeman(string weapon, string firstName, string lastName, int age) 
    : base(firstName, lastName, age)
    {
        _weapon = weapon;
        _height = 80;
    }
    public string DisplayPolicManInfo()
    {
        return $"{_weapon}, Info: {DisplayPersonInfo()}";
    }

    public override string GetName()
    {
        return $"Captain {base.GetName()}";
    }

    public override string GetHobbies()
    {
        return "Police work";
    }
}