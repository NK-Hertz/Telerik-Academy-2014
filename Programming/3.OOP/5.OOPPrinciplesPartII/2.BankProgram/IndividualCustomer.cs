public class IndividualCustomer : Customer
{
    // Fields
    private string egn;

    // Constructor
    public IndividualCustomer()
        : this(string.Empty, string.Empty) 
    { }

    public IndividualCustomer(string name, string phoneNumber)
        : this(name, phoneNumber, string.Empty) 
    { }

    public IndividualCustomer(string name, string phoneNumber, string egn)
        : base(name, phoneNumber)
    {
        this.egn = egn;
    }

    // Properties 
    //for the case we let every combination of number to be EGN
    public string EGN
    {
        get { return this.egn; }
        set { this.egn = value; }
    }
}