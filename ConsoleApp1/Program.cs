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
        int x = 0, y = 0, z = 0;
        Console.WriteLine($"start {name}");
        Console.Write("x: ");
        bool correct = false;
        while (!correct)
        {
            if (int.TryParse(Console.ReadLine(), out x))
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("введите корректное значение");
            }
        }
        correct = false;
        Console.Write("y: ");
        while (!correct)
        {
            if (int.TryParse(Console.ReadLine(), out y))
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("введите корректное значение");
            }
        }
        correct = false;
        Console.Write("z: ");
        while (!correct)
        {
            if (int.TryParse(Console.ReadLine(), out z))
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("введите корректное значение");
            }
        }
        correct = false;
        Point Start = new Point(x, y, z);
        Console.Clear();
        Console.WriteLine($"end {name}");
        Console.Write("x: ");
        while (!correct)
        {
            if (int.TryParse(Console.ReadLine(), out x))
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("введите корректное значение");
            }
        }
        correct = false;
        Console.Write("y: ");
        while (!correct)
        {
            if (int.TryParse(Console.ReadLine(), out y))
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("введите корректное значение");
            }
        }
        correct = false;
        Console.Write("z: ");
        while (!correct)
        {
            if (int.TryParse(Console.ReadLine(), out z))
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("введите корректное значение");
            }
        }
        correct = false;
        Point End = new Point(x, y, z);
        Console.Clear();
        return new Vector(Start, End);
    }
}