int Factorial (int n) // лучше использовать обьем памяти == double!!!
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1); //т.е. 5! = 5*4!
}
Console.WriteLine(Factorial(5)); //1*2*3 и др...= 120 