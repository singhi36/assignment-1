using assignment_1;

public class Person
{
    string Name { get; set; }
    int Age { get; set; }


    public bool IsAdult() => this.Age >= 18;

    public Person(string takenName, int takenAge)
    {
        this.Name = takenName;
        this.Age = takenAge;
    }

}
class Program
{

    static void Main(string[] args)
    {
        Student s1 = new Student("Inder", 29);

        Console.WriteLine(s1.IsCollegeStudent());



    }
}
