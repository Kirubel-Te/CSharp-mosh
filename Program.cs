namespace HelloWorld{

    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Doe";
            person.Introduce();
        }
    }
}
