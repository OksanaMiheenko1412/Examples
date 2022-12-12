// нахождения факториала с помощью рекурсии. 5!=5*4*3*2*1;5*4!=4*3!=3*2!


//int Factorial(int n)
//{
    // 1! = 1
    // 0! = 1
  //  if (n == 1) return 1;
    //else return n * Factorial(n - 1);
//}
//for (int i = 1; i < 40; i++)
//{
// Console.WriteLine($"{i}! = {Factorial(i)}"); //Console.WriteLine(Factorial(i));
    // в рузультате при поиске факториала до 40, в терминале
    //появляются отрицательные значения и нули, что связано с переполнением 
    //типа данных int
//} 


double   Factorial(double n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); 
} 