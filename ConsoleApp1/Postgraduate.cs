class Postgraduate : Student
{
    private String firstDegree;

    public Postgraduate()
    {

    }
    public Postgraduate(string degree, double fees, string name) : base(fees, name)
    {
        this.firstDegree = degree;
    }

    public string getFirstDegree() 
    {
        return firstDegree;
    }

    public void setFirstDegree(string degreee)
    {
        this.firstDegree = degreee;
    }
}