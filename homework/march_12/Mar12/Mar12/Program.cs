int[] numbers = {21, 63, 13, 84, 68, 40};
int largestNumber;
int smallestNumber;
largestNumber = numbers[0];
smallestNumber = numbers[0];
int x;
x = 0;
for (int i = 0; i < 5; i++)
{
    if (numbers[x] > largestNumber)
    {
        largestNumber = numbers[x];
    }
    if (numbers[x] < smallestNumber)
    {
        smallestNumber = numbers[x];
    }
    x++;
}
Console.WriteLine("Largest number is:");
Console.WriteLine(largestNumber);
Console.WriteLine("Smallest number is:");
Console.WriteLine(smallestNumber);