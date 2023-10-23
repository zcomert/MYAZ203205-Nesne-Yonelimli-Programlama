class Account
{
    //Field
    private int _index = 0;
    private double balance;

    // Property
    private double Balance
    {
        get { return balance; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Balance not enough!");
            }
            else
            {
                balance = value;
            }
        }
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return FirstName + " " + LastName; } }
    private string[] Activities { get; }
    // private List<string> Activities { get; }

    public DateTime AccountDate { get; }

    // Constructor
    public Account()
    {
        AccountDate = DateTime.Now;
        Activities = new string[16];
        //Activities = new List<string>();
    }

    // Methods
    public void Deposit(float value)
    {
        Balance += value;

        Activities[_index] = string.Format("{0} date {1} is deposited! New Balance: {2}", DateTime.Now, value, Balance);
        //Activities.Add(string.Format("{0} date {1} is deposited! New Balance: {2}", DateTime.Now, value, Balance));
        _index++;
    }

    public void Withdraw(float value)
    {
        if (value < 50 || value > 10000)
            System.Console.WriteLine("You can't withdraw less than 50 and more than 10000!");

        else
        {
            var amount = Balance - value;
            if (amount < 0)
                System.Console.WriteLine("Insufficient Balance! Can't withdraw: " + value.ToString());
            else
            {
                Balance = amount;
                Activities[_index] = string.Format("{0} date {1} is withdrawed! New Balance: {2}", DateTime.Now, value, Balance);
                _index++;
            }
        }
    }
    public void CheckAccount()
    {
        System.Console.WriteLine(string.Format("Create Date: {0}, Name: {1}, Balance: {2}", AccountDate, FullName, Balance));
    }
    public void AccountActivities()
    {
        for (int i = 0; i < _index; i++)
        {
            System.Console.WriteLine(Activities[i]);
        }
    }
}