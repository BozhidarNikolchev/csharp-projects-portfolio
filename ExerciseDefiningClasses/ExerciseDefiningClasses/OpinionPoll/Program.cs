using OpinionPoll;

int n = int.Parse(Console.ReadLine());

List<Person> people = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] inputPeople = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string name = inputPeople[0];
    int age = int.Parse(inputPeople[1]);

    Person currentPerson = new Person(name, age);
    people.Add(currentPerson);
}


foreach (Person person in people
    .Where(p => p.Age > 30)
    .OrderBy(p => p.Name))
{
    Console.WriteLine($"{person.Name} - {person.Age}");
}