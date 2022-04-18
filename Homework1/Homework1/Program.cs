while (true)
{
    Console.WriteLine("Please enter any keyboard key");
    char key = Console.ReadKey(true).KeyChar;

    if (char.ToLower(key) == 'q')
    {
        Console.WriteLine("The exit key has been pressed");
        break;
    }
    else if (char.IsDigit(key))
    {
        Console.WriteLine($"The number was pressed");
        Console.WriteLine($"{key} in ASCII = {(int)key}");
    }
    else if (char.IsControl(key))
    {
        Console.WriteLine($"The function key was pressed");
    }
    else
    {
        Console.WriteLine($"{key} in ASCII = {(int)key}");
    }
}
