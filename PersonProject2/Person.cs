class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public string DisplayPersonInfo()
    {
        return $"{_firstName} {_lastName}, Age: {_age}";
    }
}