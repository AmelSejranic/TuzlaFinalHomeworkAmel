using System;
using System.Linq;


class Student : Person, IComparable<Student>
{
    // Add automatic property email
    public string email { get; set; }

    private string location;

    // Complete setName mathod to check if string is valid. If it is set name field and return true

    public bool setName(string input)
    {
        if (input.Length < 2)
        {
            Console.WriteLine("Name must be at least two characters long");
            return false;
        }

        if (!input.All(Char.IsLetter))
        {
            Console.WriteLine("Name can only have letters");
            return false;
        }

        if (input.Substring(0, 1) == input[0].ToString().ToUpper())
        {
            Console.WriteLine("Name must start with an uppercase letter"); return false;
        }

        name = input;
        return true;

    }

    // Write getStudentInfo to return students name, lastName, email and location

    public string getStudentInfo()
    {
        return getPersonInfo() + ", " + email + ", " + location;
    }

    public string Location  //Location proprety
    {
        set
        {

            if (value == "SA" || value == "SARAJEVO" || value == "Sarajevo")
                location = "SA";

            if (value == "TZ" || value == "TUZLA" || value == "Tuzla")
                location = "TZ";

            location = "NA";
        }

        get
        {
            if (location == "TZ")
                return "Tuzla";
            if (location == "SA")
                return "Sarajevo";

            return "NA";

        }
    }

    // Write Student constructor that takes in 3 string arguments name, lastName, email 

    public Student(string name, string lastName, string email)
        : base(name, lastName)
    {
        this.email = email;
    }

    // Write Student that takes in 3 string arguments name, lastName, location

    public Student(string name, string lastName, string location)
        : base(name, lastName)
    {
        this.location = location;
    }

    // Parameterless constructor
    public Student()
        : base()
    {

    }

    // Implement IComparable so Students can be sorted by location in following order

    public int CompareTo(Student b)
    {
        // Alphabetic sortiranje
        return this.name.CompareTo(b.name);
    }


    ~Student()
    {

    }

    // Override ToString() method to return Student info (return same value as getStudentInfo)

    public override string ToString()
    {
        return getStudentInfo();
    }



}