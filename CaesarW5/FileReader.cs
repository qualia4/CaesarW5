namespace CaesarW5;

public class FileReader
{
    public char[] Read(string path)
    {
        return File.ReadAllText(path).ToCharArray();
    }
}