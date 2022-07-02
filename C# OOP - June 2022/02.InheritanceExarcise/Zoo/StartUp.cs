namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Snake snake = new Snake("Medusa");
            System.Console.WriteLine(snake.Name);

        }
    }
}