using Newtonsoft.Json;
using ConsoleApp1;
 class Program
{
    static void Main()
    {
        int[][] coordinates = new int[2][];
        Console.WriteLine("vector a");
        Coordinates(ref coordinates);
        Vector a = new Vector(coordinates[0], coordinates[1]);
        Console.WriteLine("vector b");
        Coordinates(ref coordinates);
        Vector b = new Vector(coordinates[0], coordinates[1]);
        Console.Write("длина вектора а: ");
        a.Length_();
        Console.WriteLine();
        Console.Write("длина вектора b: ");
        b.Length_();
        Console.WriteLine();
        Console.WriteLine("a * b = " + ((a.Coordinates[0] * b.Coordinates[0]) + (a.Coordinates[1] * b.Coordinates[1]) + (a.Coordinates[2] * b.Coordinates[2])));
        Console.Write("c = a + b = ");
        int[] c = SumPlus(a.Coordinates, b.Coordinates);
        for (int i = 0; i < c.Length; i++)
        {
            Console.Write(c[i] + " ");
        }
        Console.WriteLine();
        Console.Write("c = a - b = ");
        c = SumMinus(a.Coordinates, b.Coordinates); ;
        for (int i = 0; i < c.Length; i++)
        {
            Console.Write(c[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("cos(a^b) = " + Cos(a.Coordinates, b.Coordinates, a.Length, b.Length));
        string json = JsonConvert.SerializeObject(a);
        Vector Json = JsonConvert.DeserializeObject<Vector>(json);
        string path = "D:\\Новая папка";
        string fullpath = Path.Combine(path, "json.json");
        FileStream jsonFile = File.Create(fullpath);
        jsonFile.Close();
        File.WriteAllText(fullpath, json);
    }
    static void Coordinates(ref int[][] coordinates)
    {
        Console.WriteLine("start");
        coordinates[0] = new int[3];
        Console.Write("x: ");
        bool correct = false;
        while (!correct)
        {
            if (int.TryParse(Console.ReadLine(), out coordinates[0][0]))
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
            if (int.TryParse(Console.ReadLine(), out coordinates[0][1]))
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
            if (int.TryParse(Console.ReadLine(), out coordinates[0][2]))
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("введите корректное значение");
            }
        }
        correct = false;
        Console.Clear();
        Console.WriteLine("end");
        Console.Write("x: ");
        coordinates[1] = new int[3];
        while (!correct)
        {
            if (int.TryParse(Console.ReadLine(), out coordinates[1][0]))
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
            if (int.TryParse(Console.ReadLine(), out coordinates[1][1]))
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
            if (int.TryParse(Console.ReadLine(), out coordinates[1][2]))
            {
                correct = true;
            }
            else
            {
                Console.WriteLine("введите корректное значение");
            }
        }
        correct = false;
        Console.Clear();
    }
    static int[] SumPlus(int[] coordinate_a, int[] coordinate_b)
    {
        int[] coordinate = new int[3];
        coordinate[0] = coordinate_a[0] + coordinate_b[0];
        coordinate[1] = coordinate_a[1] + coordinate_b[1];
        coordinate[2] = coordinate_a[2] + coordinate_b[2];
        return coordinate;
    }
    static int[] SumMinus(int[] coordinate_a, int[] coordinate_b)
    {
        int[] coordinate = new int[3];
        coordinate[0] = coordinate_a[0] - coordinate_b[0];
        coordinate[1] = coordinate_a[1] - coordinate_b[1];
        coordinate[2] = coordinate_a[2] - coordinate_b[2];
        return coordinate;
    }

    static double Cos(int[] Coordinate_a, int[] Coordinate_b, double length_a, double length_b)
    {
        double cos;
        cos = ((Coordinate_a[0] * Coordinate_b[0]) + (Coordinate_a[1] * Coordinate_b[1]) + (Coordinate_a[2] * Coordinate_b[2])) / (length_a * length_b);
        return cos;
    }
}