namespace CaesarW5;

public class FileWriter
{
    public void Write(char[] text, string path)
    {
        using StreamWriter file = new StreamWriter(path);
        file.Write(text);
    }
}