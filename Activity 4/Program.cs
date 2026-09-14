

try {
    Console.Write("How old are you? ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You are {age} years old.");
} catch {
    Console.WriteLine("Something went wrong!");
}