using FractionMath;

namespace FractionTask.Math;

public class Tests {
    [Test]
    public void Constructor_NoParameters_CreatesEmptyFraction() {
        // Arrange
        
        // Act
        Fraction empty = new();
        
        // Assert 
        Assert.That(empty.Numerator, Is.EqualTo(0));
        Assert.That(empty.Denominator, Is.EqualTo(1));
        Assert.That(empty.Numerator == 0, Is.True);
    }
    
    [Test]
    public void Equals_TwoEqualFractions_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(1, 2);
        Fraction f2 = new Fraction(2, 4);

        // Act

        // Assert 
        Assert.That(f1, Is.EqualTo(f2));
    }
    
    [Test]
    public void Add_Method_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(3, 12);
        Fraction f2 = new Fraction(1, 4);
        Fraction f3 = new Fraction(24, 48);

        // Act

        // Assert 
        Assert.That(f1+f2, Is.EqualTo(f3));
    }
    
    [Test]
    public void Subtraction_Method_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(5, 12);
        Fraction f2 = new Fraction(2, 7);
        Fraction f3 = new Fraction(11, 84);

        // Act

        // Assert 
        Assert.That(f1-f2, Is.EqualTo(f3));
    }
    
    [Test]
    public void Multiply_Method_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(3, 7);
        Fraction f2 = new Fraction(8, 11);
        Fraction f3 = new Fraction(24, 77);

        // Act

        // Assert 
        Assert.That(f1*f2, Is.EqualTo(f3));
    }
    
    [Test]
    public void Divide_Method_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(1, 3);
        Fraction f2 = new Fraction(5, 6);
        Fraction f3 = new Fraction(6, 15);

        // Act

        // Assert 
        Assert.That(f1/f2, Is.EqualTo(f3));
    }
    
    [Test]
    public void GreaterThan_Method_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(7, 13);
        Fraction f2 = new Fraction(1, 6);

        // Act

        // Assert 
        Assert.That(f1>f2, Is.True);
    }
    
    [Test]
    public void SmallerThan_Method_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(7, 13);
        Fraction f2 = new Fraction(4, 6);

        // Act

        // Assert 
        Assert.That(f1<f2, Is.True);
    }
    
    [Test]
    public void EqualThan_Method_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(7, 13);
        Fraction f2 = new Fraction(14, 26);

        // Act

        // Assert 
        Assert.That(f1^f2, Is.True);
    }
    
    [Test]
    public void ToDouble_Method_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(3, 12);

        // Act

        // Assert 
        Assert.That(f1.ToDouble(), Is.EqualTo(0.25));
    }
    
    [Test]
    public void Equals_ReduceOfFraction_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(3, 8);
        Fraction f2 = new Fraction(36, 96);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(12, 16);

        // Act

        // Assert 
        Assert.That(f1, Is.EqualTo(f2.ToReduce()));
        Assert.That(f3, Is.EqualTo(f4.ToReduce()));
    }
}