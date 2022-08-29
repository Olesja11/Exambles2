Console.Clear();
Console.WriteLine("Введи число");
int num = int.Parse(Console.ReadLine());
int i = 0;
int chislo = num;
while (chislo > 0)
{
    chislo = chislo/10;
    i = i+1;
}
if (i<3) {
   Console.WriteLine("Третьей цифры нет"); 
}
else{
    while (i > 3) 
    {
        num = num/10;
        i = i - 1;
    }
    Console.WriteLine(num%10);
}


