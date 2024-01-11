class Program
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
        Student student = new Student();
        Person person = new Person();
        Postgraduate degree = new Postgraduate();

        Postgraduate degree1 = new Postgraduate("Medical", 4500, "DilankaYAs");

        teacher.setwage(25000);
        double wage = teacher.getWage();

        student.setFees(2500);
        double fees = student.getFees();

        person.setName("Dilanka");
        string name = student.getName();

        degree.setName("Bsc(Hons)");
        string predegree = degree.getFirstDegree();

        Console.WriteLine(degree1.getName());
        Console.WriteLine(degree1.getFees());
        Console.WriteLine(degree1.getFirstDegree());
    }
}