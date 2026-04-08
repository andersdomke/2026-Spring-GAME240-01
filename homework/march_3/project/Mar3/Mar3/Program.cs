using System;

int tally = 1;
while (tally <= 5)
{
    Console.WriteLine(tally);
    tally += 1;
}
tally = 100;
while (tally <= 150)
{
    Console.WriteLine(tally);
    tally += 1;
}
tally = 0;
while (tally <= 100)
{
    int isEven = tally % 2;
    if (isEven == 0)
    {
        Console.WriteLine(tally);
    }
    tally += 1;
}
tally = 20;
while (tally >= -20)
{
    Console.WriteLine(tally);
    tally -= 1;
}
tally = 1;
while (tally <= 100)
{
    Console.WriteLine(tally);
    tally += 3;
} 
tally = 1;
while (tally <= 1024)
{
    Console.WriteLine(tally);
    tally = tally * 2;
}
bool toStop = false;
do
{
    Console.WriteLine("Do you want the loop to stop?");
    string answer = Console.ReadLine();
    if (answer == "yes")
    {
        toStop = true;
    } 
}
while (toStop == false); 
tally = 0;
bool trufalse = true;
while (tally <= 10)
{
    Console.WriteLine(trufalse);
    if (trufalse == true)
    {
        trufalse = false;
    }
    else if (trufalse == false)
    {
        trufalse = true;
    }
    tally += 1;
}
tally = 1;
bool isEven2 = false;
while (tally <= 20)
{
    Console.WriteLine(isEven2);
    if (isEven2 == true)
    {
        isEven2 = false;
    }
    else if (isEven2 == false)
    {
        isEven2 = true;
    }
    tally += 1;
}
string[] array = {"once", "upon", "a", "midnight", "dreary"};
foreach (string word in array)
{
    Console.WriteLine(word);
}