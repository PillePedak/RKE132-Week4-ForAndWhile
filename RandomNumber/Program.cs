Random rnd = new Random();

int myRandomNum;

int randumSum = 0;

for (int i = 0; i < 3; i++)
{

    myRandomNum = rnd.Next(0, 11); // 0-10
    randumSum = randumSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"random sum total: {randumSum}");