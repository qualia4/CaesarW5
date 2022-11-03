namespace CaesarW5;

public class FileReader : Reader
{
    public char[] Read(string path)
    {
        if (File.Exists(path))
        {
            return File.ReadAllText(path).ToCharArray();
        }
        else
        {
            throw new ArgumentException("This file doesn't exist");
        }
    }
}