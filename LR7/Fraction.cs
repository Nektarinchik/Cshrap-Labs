using System;
using System.Text.RegularExpressions;

namespace LR7
{
    class Fraction : IComparable<Fraction>, IFormattable, IConvertible
    {
        public Fraction(long numerator, long denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;
        }

        public Fraction(long numerator)
        {
            Numerator = numerator;
            Denumerator = 1;
        }
        private long numerator;
        public long Numerator
        {
            get 
            {
                return numerator;
            }
            set
            {
                numerator = value;
                if (denumerator != 0 && numerator != 0)
                {
                    long gcd = GCD(Math.Abs(denumerator), Math.Abs(numerator));
                    denumerator /= gcd;
                    numerator /= gcd;
                }                
            }
        }

        private long denumerator;
        public long Denumerator
        {
            get
            {
                return denumerator; 
            }
            set
            {
                denumerator = value;
                if (denumerator == 0)
                    throw new ArgumentException("divisor cannot be zero");
                if (numerator != 0)
                {
                    long gcd = GCD(Math.Abs(denumerator), Math.Abs(numerator));
                    denumerator /= gcd;
                    numerator /= gcd;
                }
            }
        }
        private static long GCD(long firstValue, long secondValue)
        {
            long min = Min(firstValue, secondValue);
            long max = Max(firstValue, secondValue);
            if (min != 0)
                return GCD(max - min, min);
            return max;
        }
        private static long Min(long firstValue, long secondValue)
        {
            return firstValue < secondValue ? firstValue : secondValue;
        }
        private static long Max(long firstValue, long secondValue)
        {
            return firstValue > secondValue ? firstValue : secondValue;
        }

        public override string ToString()
        {
            return ToString("F", null);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format = "F";
            if (format == "F")
            {
                double res = (double)numerator / denumerator;
                return res.ToString();
            }
            else if (format == "D")
            {
                long res = numerator / denumerator;
                return res.ToString();
            }
            else if (new Regex(@"F\d*").IsMatch(format))
            {
                double res = (double)numerator / denumerator;
                return res.ToString("F" + format[1..]);
            }
            else if (new Regex(@"D\d*").IsMatch(format))
            {
                long res = numerator / denumerator;
                return res.ToString("D" + format[1..]);
            }
            else
                throw new ArgumentException("incorrect format");
        }
        public static Fraction Parse(string number)
        {
            Fraction fraction;
            if (TryParse(number, out fraction))
                return fraction;
            throw new ArgumentException("the input string is not in the correct format");
        }
        public static bool TryParse(string number, out Fraction f)
        {
            f = null;
            Regex pattern1 = new Regex(@"^(\d*)[/](\d*)$");
            Regex pattern2 = new Regex(@"^\d*$");
            Regex pattern3 = new Regex(@"^(\d*)[.,](\d*)$");
            if (pattern1.IsMatch(number))
            {
                string[] words = number.Split(new char[] { '/' });
                long numerator = long.Parse(words[0]);
                long denumerator = long.Parse(words[1]);
                f = new Fraction(numerator, denumerator);
                return true;
            }
            else if (pattern2.IsMatch(number))
            {
                long numerator = long.Parse(number);
                long denumerator = 1;
                f = new Fraction(numerator, denumerator);
                return true;
            }
            else if (pattern3.IsMatch(number))
            {
                string[] words = number.Split(new char[] { '.', ',' });
                long numerator = long.Parse(words[0]);
                long denumerator = long.Parse(words[1]);
                f = new Fraction(numerator, denumerator);
                return true;
            }
            else
                return false;
        }

        public double GetDoubleType()
        {
            return (double)numerator / denumerator;
        }
        public int CompareTo(Fraction fraction)
        {
            Fraction f = this - fraction;
            if (f.GetDoubleType() > 0)
                return 1;
            else if(f.GetDoubleType() < 0)
                return -1;
            return 0;
        }
        public override bool Equals(object obj)
        {
            return obj is Fraction fraction && CompareTo(fraction) == 0;
        }

        public override int GetHashCode()
        {
            int hashCode;
            hashCode = 10032003 * numerator.GetHashCode();
            hashCode /= 385;
            return hashCode;        
        }

        public TypeCode GetTypeCode()
        {
            return TypeCode.Object;
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            return Numerator != 0;
        }

        public byte ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(GetDoubleType());
        }
        public char ToChar(IFormatProvider provider)
        {
            return Convert.ToChar(GetDoubleType());
        }
        public DateTime ToDateTime(IFormatProvider provider)
        {
            return Convert.ToDateTime(GetDoubleType());
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(GetDoubleType());
        }

        public double ToDouble(IFormatProvider provider)
        {
            return GetDoubleType();
        }

        public short ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(GetDoubleType());
        }

        public int ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(GetDoubleType());
        }

        public long ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(GetDoubleType());
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
           return  Convert.ToSByte(GetDoubleType());
        }

        public float ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(GetDoubleType());
        }

        public string ToString(IFormatProvider provider)
        {
            return ToString("F", provider);
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(GetDoubleType(), conversionType);
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(GetDoubleType());
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(GetDoubleType());
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(GetDoubleType());
        }

        public static Fraction operator *(Fraction l, Fraction r)
        {
            return new Fraction(l.Numerator * r.Numerator, l.Denumerator * r.Denumerator);
        }

        public static Fraction operator /(Fraction l, Fraction r)
        {
            return new Fraction(l.Numerator * r.Denumerator, r.Numerator * l.Denumerator);
        }

        public static Fraction operator -(Fraction r)
        {
            return r * new Fraction(-1);
        }
        public static Fraction operator +(Fraction l, Fraction r)
        {
            long lcm = l.Denumerator * r.Denumerator / GCD(Math.Abs(l.Denumerator), Math.Abs(r.Denumerator));
            long n1 = l.Numerator * lcm / l.Denumerator;
            long n2 = r.Numerator * lcm / r.Denumerator;
            return new Fraction(n1 + n2, lcm);
        }
        public static Fraction operator -(Fraction l, Fraction r)
        {
            return l + (-r);
        }
        public static bool operator <(Fraction l, Fraction r)
        {
            return l.CompareTo(r) < 0;
        }
        public static bool operator <=(Fraction l, Fraction r)
        {
            return l.CompareTo(r) <= 0;
        }
        public static bool operator >(Fraction l, Fraction r)
        {
            return l.CompareTo(r) > 0;
        }
        public static bool operator >=(Fraction l, Fraction r)
        {
            return l.CompareTo(r) >= 0;
        }
        public static bool operator ==(Fraction l, Fraction r)
        {
            return l.CompareTo(r) == 0;
        }
        public static bool operator !=(Fraction l, Fraction r)
        {
            return l.CompareTo(r) != 0;
        }
    }
}
