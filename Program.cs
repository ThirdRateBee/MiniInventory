
using System.Security.Cryptography.X509Certificates;

Character b = new();

while (true)
{

    b.Backpack.Display();

    if (b.Backpack.Items.Count == 2)
    {
        Console.WriteLine("There is a helmet in front of you");
        Console.WriteLine("Do you want to pick it up?");
        Console.WriteLine("Yes[Y] : No[N]");

        String choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "y")
        {
            Armor Helmet = new();
            b.Backpack.Items.Add(Helmet);
        Console.WriteLine("You stole the helmet!");
        }
    }


    String choice2 = Console.ReadLine();
    choice2 = choice2.ToLower();

}
