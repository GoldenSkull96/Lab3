using Newtonsoft.Json;
using ConsoleApp1;
 class Program
{
    static void Main()
    {
        Vector a = Coordinates("a");
        Vector b = Coordinates("b");
        Console.WriteLine($"длина вектора а: {a.Length}");
        Console.WriteLine($"длина вектора b: {b.Length}");
        string json = JsonConvert.SerializeObject(a);
        Vector Json = JsonConvert.DeserializeObject<Vector>(json);
        string path = "D:\\Новая папка";
        string fullpath = Path.Combine(path, "json.json");
        FileStream jsonFile = File.Create(fullpath);
        jsonFile.Close();
        File.WriteAllText(fullpath, json);
    }
    static Vector Coordinates(string name)
    {
        Console.WriteLine($"start {name}");
        int x = input("x");
        int y = input("y");
        int z = input("z");
        Point Start = new Point(x, y, z);
        Console.Clear();
        Console.WriteLine($"end {name}");
        x = input("x");
        y = input("y");
        z = input("z");
        Point End = new Point(x, y, z);
        Console.Clear();
        return new Vector(Start, End);
    }
    static int input(string name)
    {
        Console.Write($"{name}: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                return n;
            }
            else
            {
                Console.WriteLine("введите корректное значение в формате int");
            }
        }
        return 0;
    }
}