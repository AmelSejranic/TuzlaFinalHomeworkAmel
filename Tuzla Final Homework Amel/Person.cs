class Person
{
    protected string lastName;
    public string name;

    // Modify Person class Add count property so we can count number of Person objects created. 

    private static int _count = 0;

    public static int count
    {
        get
        {
            return _count;
        }

        private set
        {
            _count = value;
        }
    }

    Person(string name, string lastName)
    {
        this.name = name;
        this.lastName = lastName;
        // needed for counting created Person objects
        count++;

    }
    protected string getPersonInfo() { return name + ", " + lastName; }
};