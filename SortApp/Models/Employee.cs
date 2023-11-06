namespace SortApp.Models;
public class Employee : IComparable, ICloneable
{
    #region default
    public String? FirstName { get; set; }
    public String? LastName { get; set; }
    public double Salary { get; set; }
    public override string ToString()
    {
        return $"{FirstName,-10} {LastName,-10} {Salary,-10}";
    }
    #endregion
    public int CompareTo(object? obj)
    {
        var other = (Employee)obj;
        // return this.Salary.CompareTo(other.Salary);
        
        // if(this.Salary<other.Salary)
        //     return 1;
        // else if(this.Salary==other.Salary)
        //     return 0;
        // else
        //     return -1;

        return this.FirstName.CompareTo(other.FirstName);
    }

    public object Clone()
    {
        return new Employee()
        {
            FirstName = this.FirstName,
            LastName = this.LastName,
            Salary = this.Salary
        };
    }
}