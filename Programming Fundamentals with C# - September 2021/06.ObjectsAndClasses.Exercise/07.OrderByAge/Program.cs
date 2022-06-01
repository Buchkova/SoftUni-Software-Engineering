using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split();
                string name = data[0];
                string id = data[1];
                int age = int.Parse(data[2]);

                var person = new Person(name, id, age);

                if (people.Any(x => x.ID == id))
                {
                    foreach (Person personn in people)
                    {
                        if (personn.ID == id)
                        {
                            personn.Name = name;
                            personn.Age = age;
                        }
                    }
                }
                else
                {
                    people.Add(person);
                }

                input = Console.ReadLine();
            }

            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
}

class Person
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }

    public Person(string name, string id, int age)
    {
        this.Name = name;
        this.ID = id;
        this.Age = age;
    }

    public void EditNameAndAge(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} with ID: {ID} is {Age} years old.";
    }
}

