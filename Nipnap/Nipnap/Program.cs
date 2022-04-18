

Console.WriteLine("Nip Nap Snip Snap\nr for red, b for blue, g for green, p for purple\n");


char temp = Console.ReadLine()[0];
string tempstring = "";

switch (temp)
{
    case 'r':
        Console.WriteLine("flip flap flip\n");
        tempstring += "red";
        break;
    case 'b':
        Console.WriteLine("flip flap flip flap\n");
        tempstring += "blue";
        break;
    case 'g':
        Console.WriteLine("flip flap flip flap flip\n");
        tempstring += "green";
        break;
    case 'p':
        Console.WriteLine("flip flap flip flap flip flap\n");
        tempstring += "purple";
        break;
    default:
        Console.WriteLine("Uhoh, that is not a valid entry");
        break;
}

Console.WriteLine("Nip Nap Snip Snap. Do it again. \nr for red, b for blue, g for green, p for purple\n");

temp = Console.ReadLine()[0];

switch (temp)
{
    case 'r':
        Console.WriteLine("flip flap flip\n");
        tempstring += "red";
        break;
    case 'b':
        Console.WriteLine("flip flap flip flap\n");
        tempstring += "blue";
        break;
    case 'g':
        Console.WriteLine("flip flap flip flap flip\n");
        tempstring += "green";
        break;
    case 'p':
        Console.WriteLine("flip flap flip flap flip flap\n");
        tempstring += "purple";
        break;
    default:
        Console.WriteLine("Uhoh, that is not a valid entry");
        break;
}


int equal = tempstring.Length % 2;

if (equal == 0)
{
    Console.WriteLine("Choose a door between 1-4");
    char tempdooreven = Console.ReadLine()[0];

    switch (tempdooreven)
    {
        case '1':
            Console.WriteLine("You look like you eat aglets?");
            break;
        case '2':
            Console.WriteLine("You look like a toad");
            break;
        case '3':
            Console.WriteLine("You look like a hippo");
            break;
        case '4':
            Console.WriteLine("You look like a cat");
            break;
        default:
            Console.WriteLine("Uhoh, that is not a valid entry");
            break;
    }


}

if (equal == 1)
{
    Console.WriteLine("Choose a door between 1-4");
    char tempdoorodd = Console.ReadLine()[0];

    switch (tempdoorodd)
    {
        case '1':
            Console.WriteLine("You look like an alpaca");
            break;
        case '2':
            Console.WriteLine("You look like a dog");
            break;
        case '3':
            Console.WriteLine("You look like a fish");
            break;
        case '4':
            Console.WriteLine("You look like a bear");
            break;
        default:
            Console.WriteLine("Uhoh, that is not a valid entry");
            break;
    }

}

