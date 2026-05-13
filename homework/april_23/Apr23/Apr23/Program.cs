bool Success1 = false;
bool Success2 = false;
bool Success3 = false;
StreamReader specialWriter = null;
StreamReader fishWriter = null;
StreamReader resultReader = null;
StreamWriter resultWriter = null;

while (Success1 == false)
{
    try
    {
        Console.WriteLine("What is the file path for today's special?");
        string specialPath = Console.ReadLine();
        specialWriter = new StreamReader(specialPath);
        Success1 = true;
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Invalid file path! Try again.");
    }
    
}
while (Success2 == false)
{
    try
    {
        Console.WriteLine("What is the file path for the fishmonger's log?");
        string fishPath = Console.ReadLine();
        fishWriter = new StreamReader(fishPath);
        Success2 = true;
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Invalid file path! Try again.");
    }
}
while (Success3 == false)
{
    try
    {
        Console.WriteLine("Where do you want to save the result?");
        string resultPath = Console.ReadLine();
        resultReader = new StreamReader(resultPath);
        Success3 = true;
        resultWriter = new StreamWriter(resultPath);
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("Invalid file path! Try again.");
    }
    
}

string specialsLine = specialWriter.ReadLine();
string[] specialsSplit = specialsLine.Split(' ');
string special = specialsSplit[3];
string fishLine = fishWriter.ReadLine();
string[] fishSplit = null;
int totalFish = 0;
int specialFish = 0;
while (fishLine != null)
{
    fishSplit = fishLine.Split(' ');
    totalFish += int.Parse(fishSplit[0]);
    if (fishSplit[1] == special)
    {
        specialFish += int.Parse(fishSplit[0]);
    }
    fishLine = fishWriter.ReadLine();
}

specialWriter.Close();
fishWriter.Close();
resultWriter.WriteLine("Today's special is " + special);
resultWriter.WriteLine("Total " + special + " caught: " + specialFish);
resultWriter.WriteLine("Total fish caught: " + totalFish);


