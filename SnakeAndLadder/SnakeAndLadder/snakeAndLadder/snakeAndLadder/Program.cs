// See https://aka.ms/new-console-template for more information
Console.WriteLine("WelCome To Snake And Ladder");

Program SnakeAndLadder;

int position = 0;
const int LADDER = 1;
const int SNAKE = 2;

Random random = new Random();
int option = random.Next(0,3);
int rollDie = random.Next(1,7);
switch (option)
{
    case LADDER:
        position = position + rollDie;
        break;
    case SNAKE :
       position -=  rollDie;
        break;
    default:
        
        break;
}
Console.WriteLine( position);



