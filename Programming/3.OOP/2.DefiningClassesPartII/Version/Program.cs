using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Struct |
AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
public class VersionAttribute : System.Attribute
{
    public string Version { get; private set; }

    public VersionAttribute(string version)
    {
        this.Version = version;
    }


}
[assembly: AssemblyVersionAttribute("1.0")]
public class Program
{

    static void Main()
    {
        Type type = typeof(Program);
        object[] allAttributes = type.GetCustomAttributes(false);

        foreach (VersionAttribute attr in allAttributes)
        {
            Console.WriteLine("Version = {0} ", attr.Version);
        }
    }



}
