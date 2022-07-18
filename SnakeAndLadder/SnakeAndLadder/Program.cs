// See https://aka.ms/new-console-template for more information
Console.WriteLine("WelCome To Snake And Ladder");

int position = 0;
Random random = new Random();
int rolldie = random.Next(1, 7);

Console.WriteLine("player 1 position is " + position);
Console.WriteLine("Roll Die value; " + rolldie);
