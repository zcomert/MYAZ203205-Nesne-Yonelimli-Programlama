class Employee
{
    private string firstName;
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName { get; set; } =string.Empty;

    private decimal salary;
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public string FullName
    {
        get { return firstName + " " + LastName.ToUpper(); }
    }
}