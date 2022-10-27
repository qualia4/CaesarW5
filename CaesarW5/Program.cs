using Caesar;

while (true)
{
    Console.WriteLine("Write text:");
    char[] text = Console.ReadLine().ToCharArray();
    Console.WriteLine("Write key:");
    var key = Console.ReadLine();
    Console.WriteLine("Write 1 if encrypt and 2 if decrypt");
    var result = new char[] { };
    var crypter = new CaesarCrypt();
    if (Console.ReadLine() == "1")
    {
        result = crypter.Encrypt(text, int.Parse(key));
    }
    else
    {
        result = crypter.Decrypt(text, int.Parse(key));
    }
    crypter.Print(result);
}