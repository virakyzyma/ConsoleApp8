namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            string str = "x w x y x w";
            int x = 0, w = 0, y = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'x')
                {
                    x++;
                }
                else if (str[i] == 'w')
                {
                    w++;
                }
                else if (str[i] == 'y')
                {
                    y++;
                }
            }
            Console.WriteLine($"X-> {x}\tY-> {y}\tW-> {w}");
        }
    }
}
