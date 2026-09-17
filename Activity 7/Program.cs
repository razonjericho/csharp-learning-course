
// string[] favouriteLanguages = { "C#", "JavaScript", "Python" };

// Console.WriteLine("My favourite languages are:");

// for (int i = 0; i < favouriteLanguages.Length; i++) {
//     Console.WriteLine(favouriteLanguages[i]);
// }

// int[] numbers = { 10, 25, 30, 45, 50 };

// for (int i = 0; i < numbers.Length; i++) {
//     if (numbers[i] > 30) {
//         Console.WriteLine(numbers[i]);
//     }
// }

// int[] numbers = { 10, 25, 30, 45, 50 };

// int largest = numbers[0];

// for (int i = 0; i < numbers.Length; i++) {
//     if (numbers[i] > largest) {
//         largest = numbers[i];
//     }
// }

// Console.WriteLine($"The largest number is: {largest}");

int[] numbers = { 10, 25, 30, 45, 50, 30, 15, 30 };

int count = 0;

for (int i = 0; i < numbers.Length; i++) {
    if (numbers[i] == 30) {
        count++;
    }
}

Console.WriteLine($"The number 30 appears {count} times");


