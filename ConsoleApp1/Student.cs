class Student : Person
{
    private double fees;

    public Student()
    {

    }

    public Student(double fees, string name) : base(name)
    {
        this.fees = fees;
    }

    public double getFees()
    {
        return fees;
    }

    public void setFees(double fees)
    {
        this.fees = fees;
    }
}