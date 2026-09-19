
Person person1 = new Person();

person1.name = "Jericho";
person1.age = 24;
person1.city = "Cebu City";

Person person2 = new Person();

person2.name = "Maria";
person2.age = 23;
person2.city = "Cebu City";

// Console.WriteLine(person1.name);
// Console.WriteLine(person1.age);
// Console.WriteLine(person1.city);

// Console.WriteLine(person2.name);
// Console.WriteLine(person2.age);
// Console.WriteLine(person2.city);

// person1.SayHello();
// person2.SayHello();

// class Person
// {
//     public string name;
//     public int age;
//     public string city;

//     public void SayHello(){
//         Console.WriteLine($"Hello, my name is {name}");
//     }
// }

// person1.Introduce();
// person2.Introduce();

// class Person
// {
//     public string name;
//     public int age;
//     public string city;

//     public void Introduce(){
//         Console.WriteLine($"Hello, my name is {name}, I am {age} years old, and I live in {city}.");
//     }
// }

person1.SaySomething("Hello, everyone!");
person2.SaySomething("Hello, everyone!");

int person1Age = person1.GetAge();
int person2Age = person2.GetAge();
Console.WriteLine($"{person1.name}'s age: {person1Age}");
Console.WriteLine($"{person2.name}'s age: {person2Age}");
bool person1IsAdult = person1.IsAdult();
bool person2IsAdult = person2.IsAdult();
Console.WriteLine($"{person1.name} is an adult: {person1IsAdult}");
Console.WriteLine($"{person2.name} is an adult: {person2IsAdult}");

class Person
{
    public string name;
    public int age;
    public string city;

    public void SaySomething(string message){
        Console.WriteLine($"{name} says: {message}");
    }

    public int GetAge(){
        return age;
    }

    public bool IsAdult(){
        return age >= 18;
    }
}