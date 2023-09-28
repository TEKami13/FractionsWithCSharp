namespace Math; 

public class Fraction {
     public Fraction(int numerator = 0, int denominator = 1) {
          if (denominator == 0) {
               throw new ArgumentOutOfRangeException(nameof(denominator),
                    "You can't have 0 as a denominator");
          } else {
               Numerator = numerator;
               Denominator = denominator;
          }
     }
     
     public int Numerator { get; set; }
     public int Denominator { get; set; }

     #region toSomethingCode
     
     public Fraction ToReduce() {
          Fraction sum;
          int newNumerator = Numerator;
          int newDenominator = Denominator;
          double num = Numerator;
          double den = Denominator;

          for (int i = 0; i < 10; i++) {
               for (int j = 10; j >= 0; j--) {
                    if (num % j == 0 && den % j == 0) {
                         newNumerator = (int)num/j;
                         newDenominator = (int)den/j;
                         num = newNumerator;
                         den = newDenominator;
                    } 
               } 
          }
          sum = new(newNumerator, newDenominator);
          return sum;
     }

     public override string ToString() {
          return $"{Numerator}/{Denominator}";
     }

     public double ToDouble() {
          double nmbr = (double)Numerator/Denominator;
          return nmbr;
     }
     #endregion

     #region equalsCode
     
     public override bool Equals(object? obj) {
          if (obj is Fraction other) {
               return Equals(other);
          } else {
               return false;
          }
     }

     public bool Equals(Fraction other) {
          //return Numerator == other.Numerator && Denominator == other.Denominator;
          return (Numerator * other.Denominator) == (Denominator * other.Numerator);
     }
     #endregion

     #region mathCode

     #region addCode
     
     public Fraction Add(Fraction other) {
          int newNumerator = Numerator * other.Denominator + Denominator * other.Numerator;
          int newDenominator = Denominator * other.Denominator;
          Fraction sum = new(newNumerator, newDenominator);
          return sum;
     }
     
     public static Fraction Add(Fraction left, Fraction right) {
          int newNumerator = left.Numerator * right.Denominator + left.Denominator * right.Numerator;
          int newDenominator = left.Denominator * right.Denominator;
          return new(newNumerator, newDenominator);
     }

     public static Fraction operator +(Fraction left, Fraction right) {
          //return left.Add(right); // for ikke static metoden
          return Add(left, right); //static metoden
     }
     
     #endregion

     #region subtractCode
     
     public Fraction Subtract(Fraction other) {
          int newNumerator = Numerator * other.Denominator - Denominator * other.Numerator;
          int newDenominator = Denominator * other.Denominator;
          Fraction sum = new(newNumerator, newDenominator);
          return sum;
     }

     public static Fraction Subtract(Fraction left, Fraction right) {
          int newNumerator = left.Numerator * right.Denominator - left.Denominator * right.Numerator;
          int newDenominator = left.Denominator * right.Denominator;
          return new(newNumerator, newDenominator);
     }
     
     public static Fraction operator -(Fraction left, Fraction right) {
          //return left.Subtract(right); // For not static method
          return Subtract(left, right); // Static method
     }
     #endregion
     
     #region multiplyCode
     
     public Fraction Multiply(Fraction other) {
          int newNumerator = Numerator * other.Numerator;
          int newDenominator = Denominator * other.Denominator;
          Fraction sum = new(newNumerator, newDenominator);
          return sum;
     }

     public static Fraction Multiply(Fraction left, Fraction right) {
          int newNumerator = left.Numerator * right.Numerator;
          int newDenominator = left.Denominator * right.Denominator;
          return new(newNumerator, newDenominator);
     }

     public static Fraction operator *(Fraction left, Fraction right) {
          //return left.Multiply(right); // for ikke static metoden
          return Multiply(left, right); //static metoden
     }
     #endregion
     
     #region divideCode
     
     public Fraction Divide(Fraction other) {
          int newNumerator = Numerator * other.Denominator;
          int newDenominator = Denominator * other.Numerator;
          Fraction sum = new(newNumerator, newDenominator);
          return sum;
     }

     public static Fraction Divide(Fraction left, Fraction right) {
          int newNumerator = left.Numerator * right.Denominator;
          int newDenominator = left.Denominator * right.Numerator;
          return new(newNumerator, newDenominator);
     }

     public static Fraction operator /(Fraction left, Fraction right) {
          //return left.Add(right); // for ikke static metoden
          return Divide(left, right); //static metoden
     }
     #endregion
     
     #region greaterThanCode
     
     public Boolean GreaterThan(Fraction other) {
          int otherNumerator = other.Numerator * Denominator;
          int newNumerator = Numerator * other.Denominator;
          if (newNumerator > otherNumerator) {
               return true;
          } else if (newNumerator == otherNumerator) {
               return false;
          } else {
               return false;
          }
     }

     public static Boolean GreaterThan(Fraction left, Fraction right) {
          int rightNumerator = right.Numerator * left.Denominator;
          int newNumerator = left.Numerator * right.Denominator;
          if (newNumerator > rightNumerator) {
               return true;
          } else if (newNumerator == rightNumerator) {
               return false;
          } else {
               return false;
          }
     }

     public static Boolean operator >(Fraction left, Fraction right) {
          //return left.Add(right); // for ikke static metoden
          return GreaterThan(left, right); //static metoden
     }
     #endregion
     
     #region smallerThanCode
     
     public Boolean SmallerThan(Fraction other) {
          int otherNumerator = other.Numerator * Denominator;
          int newNumerator = Numerator * other.Denominator;
          if (newNumerator > otherNumerator) {
               return false;
          } else if (newNumerator == otherNumerator) {
               return false;
          } else {
               return true;
          }
     }

     public static Boolean SmallerThan(Fraction left, Fraction right) {
          int rightNumerator = right.Numerator * left.Denominator;
          int newNumerator = left.Numerator * right.Denominator;
          if (newNumerator > rightNumerator) {
               return false;
          } else if (newNumerator == rightNumerator) {
               return false;
          } else {
               return true;
          }
     }

     public static Boolean operator <(Fraction left, Fraction right) {
          //return left.Add(right); // for ikke static metoden
          return SmallerThan(left, right); //static metoden
     }
     #endregion
     
     #region equalThanCode
     
     public Boolean EqualThan(Fraction other) {
          int otherNumerator = other.Numerator * Denominator;
          int newNumerator = Numerator * other.Denominator;
          if (newNumerator > otherNumerator) {
               return false;
          } else if (newNumerator == otherNumerator) {
               return true;
          } else {
               return false;
          }
     }

     public static Boolean EqualThan(Fraction left, Fraction right) {
          int rightNumerator = right.Numerator * left.Denominator;
          int newNumerator = left.Numerator * right.Denominator;
          if (newNumerator > rightNumerator) {
               return false;
          } else if (newNumerator == rightNumerator) {
               return true;
          } else {
               return false;
          }
     }

     public static Boolean operator ^(Fraction left, Fraction right) {
          //return left.Add(right); // for ikke static metoden
          return EqualThan(left, right); //static metoden
     }
    #endregion
    
    #endregion
}