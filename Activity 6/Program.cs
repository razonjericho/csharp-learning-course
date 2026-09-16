
// static int AddNumbers(int a, int b) {
//     return a + b;
// }

// int result = AddNumbers(5, 1);
// Console.WriteLine(result);

// static bool IsAdult(int age) {
//     return age >= 18;
// }

// int age = 21;
// bool result = IsAdult(age);

// if (result) {
//     Console.WriteLine($"Age: {age}");
//     Console.WriteLine("You are an adult.");
// } else {
//     Console.WriteLine($"Age: {age}");
//     Console.WriteLine("You are not an adult yet.");
// }

static bool IsAdult(int age) {
    return age >= 18;
}

try {

    Console.Write("What is your name? ");
    string name = Console.ReadLine();

    Console.Write("How old are you? ");
    bool result = IsAdult(Convert.ToInt32(Console.ReadLine()));

    if(!result) {
        Console.WriteLine($"Hello {name}!");
        Console.WriteLine($"You are not an adult yet");
    } else {
        Console.WriteLine($"Hello {name}!");
        Console.WriteLine($"You are an adult");
    }
} catch {
    Console.WriteLine("Something went wrong!");
}