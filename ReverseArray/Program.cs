var exampleArray = new int[10];

// populate input array with random numbers
var rng = new Random();
for (var i = 0; i < exampleArray.Length; i++)
{
    exampleArray[i] = rng.Next(50);
}

// print original array to console
Console.WriteLine("input array: ");
foreach (var item in exampleArray)
{
    Console.WriteLine(item);
}

//reverse it
var reversedArray = Challenge.ReverseArray(exampleArray);


// print results
Console.WriteLine("reversed array: ");
foreach (var item in reversedArray)
{
    Console.WriteLine(item);
}

Console.ReadLine();

class Challenge
{
    public static int[] ReverseArray(int[] input)
    {
        for (var i = 0; i < input.Length / 2; i++)
        {
            var temp = input[i];
            input[i] = input[^(i + 1)];
            input[^(i + 1)] = temp;
        }

        return input;
    }
}