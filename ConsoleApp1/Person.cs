class Person
{
    private string name;

    //public string Name
    //{
    //    get { return name; }
    //    set { name = value; }
    //}

    public Person() { }

    public Person(string name) 
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

}