// See https://aka.ms/new-console-template for more information


using Math;

Fraction empty;
Fraction oneHalf;
Fraction oneHalf2;
Fraction threeQuarter;
Fraction reduceTest;

try {
    empty = new();
    oneHalf = new(1, 2);
    oneHalf2 = new(5, 10);
    threeQuarter = new(3, 4);
    reduceTest = new(9, 30);
}
catch (ArgumentOutOfRangeException){
    Console.WriteLine("You can't use 0 as a denominator");
    return;
}

Console.WriteLine($"1111111Sum is: {oneHalf.ToDouble()}");
Fraction sum = oneHalf.Add(threeQuarter);
Fraction sum1 = Fraction.Add(oneHalf, threeQuarter);
Console.WriteLine($"Sum is: {sum}");

Fraction sumM = oneHalf.Subtract(threeQuarter);
Console.WriteLine(sumM);

Fraction SumMu = oneHalf* threeQuarter;
Console.WriteLine(SumMu);

Fraction SumDi = Fraction.Divide(oneHalf, threeQuarter);
Console.WriteLine(SumDi);

Boolean SumGr = Fraction.GreaterThan(oneHalf, threeQuarter);
Console.WriteLine(SumGr);

Boolean SumEq = Fraction.EqualThan(oneHalf, oneHalf2);
Console.WriteLine(SumEq);

Boolean SumSm = Fraction.SmallerThan(oneHalf, threeQuarter);
Console.WriteLine(SumSm);

Console.WriteLine(reduceTest.ToDouble());
Console.WriteLine(reduceTest);
Console.WriteLine(reduceTest.toReduce());