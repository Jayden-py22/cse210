class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    protected int _height;

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public string DisplayPersonInfo()
    {
        return $"Information: {_firstName} {_lastName}, Age: {_age}";
    }

    public int GetHeight()
    {
        return _height;
    }

    public void SetHeight(int height)
    {
        if (height < 40 || height > 90)
            _height = 60;
        else
            _height = height;
    }

    public virtual string GetName()
    {
        return $"{_firstName} {_lastName}";
    }

    public abstract string GetHobbies();
}

