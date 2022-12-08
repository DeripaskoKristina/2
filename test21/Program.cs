Console.WriteLine("Введи трёхзначное число: ");
Random rnd = new Random();
int number = rnd.Next(100,1000);

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);