using ExerciseDefiningClasses;

public class StartUp
{
    public static void Main(string[] args)
    {
        //Person p1 = new Person();
        //p1.Name = "Pepi";
        //p1.Age = 35;

        //Person p2 = new Person { Name = "Koko", Age = 31 };

        //Person p3 = new Person("Jose", 98);

        //////////////////////////////////////////////////////////////////////////
        ///

        int n = int.Parse(Console.ReadLine());

        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            string[] inputPerson = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = inputPerson[0];
            int age = int.Parse(inputPerson[1]);

            Person currentPerson = new Person(name, age);
            family.AddMember(currentPerson);
        }

        Person oldestPerson = family.GetOldestMember();
        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
    }
}
