// 

System.Random numSint = new System.Random();

int rndNmb = numSint.Next(100,1000);
Console.WriteLine(rndNmb);
int lastDig = rndNmb%10;
int firstDig = rndNmb/100;
int resultNumber = firstDig*10+lastDig;
Console.WriteLine(resultNumber);
