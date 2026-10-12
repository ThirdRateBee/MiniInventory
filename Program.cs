
Character b = new();

while(true)
{
    String choice = Console.ReadLine();
    choice = choice.ToLower();

    if (choice == "i")
    {
        b.Backpack.Display();
    }
}
