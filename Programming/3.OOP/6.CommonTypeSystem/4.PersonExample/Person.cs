using System;
using System.Text;

class Person
{
    private string name;
    private uint? age;

    public Person(string name)
        : this(name, null)
    { }

    public Person(string name, uint? age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public uint? Age 
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public override string ToString()
    {
        StringBuilder information = new StringBuilder();
        information.AppendLine(this.name.ToString());
        
        if (age != null)
        {
            information.AppendLine(this.age.ToString());
        }
        else
        {
            information.AppendLine("Age is not specified!");
        }
        
        return information.ToString();
    }
}