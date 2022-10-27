using Caesar;
using CaesarW5;

FileWriter writer = new FileWriter();
FileReader reader = new FileReader();
CaesarCrypt crypter = new CaesarCrypt();

while (true)
{
    Console.WriteLine("Do you wanna enter secret mode?");
    if (Console.ReadLine() == "yes")
    {
        Console.WriteLine("Write path to read file from:");
        char[] text = reader.Read(Console.ReadLine());
        Random rd = new Random();
        int key = rd.Next(1,26);
        Console.WriteLine(key);
        char[] result = crypter.Encrypt(text, key);
        crypter.Print(result);
        Console.WriteLine("Do you wanna save result?");
        if (Console.ReadLine() == "yes")
        {
            Console.WriteLine("Enter path to save:");
            writer.Write(result, Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("Write path to read file from:");
        char[] text = reader.Read(Console.ReadLine());
        Console.WriteLine("Write key:");
        var key = Console.ReadLine();
        Console.WriteLine("Write 1 if encrypt and 2 if decrypt");
        var result = new char[] { };
        if (Console.ReadLine() == "1")
        {
            result = crypter.Encrypt(text, int.Parse(key));
        }
        else
        {
            result = crypter.Decrypt(text, int.Parse(key));
        }
        crypter.Print(result);
        Console.WriteLine("Do you wanna save result?");
        if (Console.ReadLine() == "yes")
        {
            Console.WriteLine("Enter path to save:");
            writer.Write(result, Console.ReadLine());
        }
        Console.WriteLine("Do you wanna finish?");
        if (Console.ReadLine() == "yes")
        {
            break;
        }
    }

}