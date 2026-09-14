
Console.Write("What is your name? ");
string name = Console.ReadLine();

Console.Write("How old are you? ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Are you a student? ");
bool isStudent = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine($"Hello, {name}!");

if (age >= 19 && age < 60) {
    Console.WriteLine("You are an adult!");
    if (!isStudent) {
        Console.WriteLine("You do not qualify for a student discount!");
    } else {
        Console.WriteLine("You qualify for a student discount!");
    }
} else if (age <= 18) {
    Console.WriteLine("You are not an adult yet.");
    if (!isStudent) {
        Console.WriteLine("You do not qualify for a student discount!");
    } else {
        Console.WriteLine("You qualify for a student discount!");
    }
} else if (age >= 60) {
    Console.WriteLine("You are a senior!");
    if (!isStudent) {
        Console.WriteLine("You do not qualify for a student discount!");
    } else {
        Console.WriteLine("You qualify for a student discount!");
    }
}