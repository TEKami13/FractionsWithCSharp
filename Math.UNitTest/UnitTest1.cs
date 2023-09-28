using Math;

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
    public void Equals_ReduceOfFraction_ReturnsTrue() {
        // Arrange
        Fraction f1 = new Fraction(3, 8);
        Fraction f2 = new Fraction(36, 96);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(12, 16);

        // Act

        // Assert 
        Assert.That(f1, Is.EqualTo(f2.toReduce()));
        Assert.That(f3, Is.EqualTo(f4.toReduce()));
    }
}