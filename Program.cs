namespace AOC2015Day2
{
    class Program
    {
        static string PartOne(string data)
        {
            int totalSize = 0;
            foreach (string line in data.Split("\n"))
            {
                if (line != "")
                {
                    int[] sides = Array.ConvertAll(line.Split('x'), int.Parse);
                    int length = sides[0];
                    int width = sides[1];
                    int height = sides[2];

                    int size = 0;
                    int smallestSize = int.MaxValue;
                    foreach (int side in new int[3] { length * width, width * height, height * length })
                    {
                        if (side < smallestSize)
                        {
                            smallestSize = side;
                        }
                        size += 2 * side;
                    }
                    size += smallestSize;
                    totalSize += size;
                }
            }
            return Convert.ToString(totalSize);
        }
        static string PartTwo(string data)
        {
            int totalSize = 0;
            foreach (string line in data.Split("\n"))
            {
                if (line != "")
                {
                    int[] sides = Array.ConvertAll(line.Split('x'), int.Parse);
                    int length = sides[0];
                    int width = sides[1];
                    int height = sides[2];

                    int size = length * width * height;
                    int smallestPerimeter = int.MaxValue;
                    foreach (int perimiter in new int[3] { 2 * (length + width), 2 * (width + height), 2 * (height + length) })
                    {
                        if (perimiter < smallestPerimeter)
                        {
                            smallestPerimeter = perimiter;
                        }
                    }
                    size += smallestPerimeter;
                    totalSize += size;
                }
            }
            return Convert.ToString(totalSize);
        }
        static void Main()
        {
            string file = File.ReadAllText(@"../../../input.txt");
            Console.WriteLine(PartOne(file));
            Console.WriteLine(PartTwo(file));
        }
    }
}