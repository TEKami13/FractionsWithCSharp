// See https://aka.ms/new-console-template for more information


using FractionMath;

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

var sumAdd = oneHalf.Add(threeQuarter);
Console.WriteLine($"Sum of the Add is: {sumAdd}");

var sumSubtract = oneHalf.Subtract(threeQuarter);
Console.WriteLine($"Sum of the Subtract is: {sumSubtract}");

var sumMultiply = oneHalf* threeQuarter;
Console.WriteLine($"Sum of the Multiply is: {sumMultiply}");

var sumDivide = Fraction.Divide(oneHalf, threeQuarter);
Console.WriteLine($"Sum of the divide is: {sumDivide}");

var sumGreaterThan = Fraction.GreaterThan(oneHalf, threeQuarter);
Console.WriteLine($"Is {oneHalf} greater than {threeQuarter}?\n" +
                  $"{sumGreaterThan}");

var sumSmallerThan = Fraction.SmallerThan(oneHalf, threeQuarter);
Console.WriteLine($"Is {oneHalf} smaller than {threeQuarter}?\n" +
                  $"{sumSmallerThan}");

var sumEqualThan = Fraction.EqualThan(oneHalf, oneHalf2);
Console.WriteLine($"Is {oneHalf} equal to {threeQuarter}?\n" +
                  $"{sumEqualThan}");

Console.WriteLine($"{reduceTest} as number {reduceTest.ToDouble()}");
Console.WriteLine($"{reduceTest} as reduced as possible: {reduceTest.ToReduce()}");