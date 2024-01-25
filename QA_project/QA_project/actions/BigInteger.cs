using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QA_project.actions
{

    public interface IArithmeticOperations
    {

        BigInteger AddBigIntegers(BigInteger firstVal, BigInteger secondVal);
        BigInteger ExtractBigIntegers(BigInteger firstVal, BigInteger secondVal);
        BigInteger MultiplyBigIntegers(BigInteger firstVal, BigInteger secondVal);
        BigInteger DivideBigIntegers(ref BigInteger firstVal, ref BigInteger secondVal);
    }
    public class ArithmeticWrapper : IArithmeticOperations
    {

        public BigInteger AddBigIntegers(BigInteger firstVal, BigInteger secondVal)
        {
            return BigIntegers.AddBigIntegers(firstVal, secondVal);
        }

        public BigInteger ExtractBigIntegers(BigInteger firstVal, BigInteger secondVal)
        {
            return BigIntegers.ExtractBigIntegers(firstVal, secondVal);
        }

        public BigInteger MultiplyBigIntegers(BigInteger firstVal, BigInteger secondVal)
        {
            return BigIntegers.MultiplyBigIntegers(firstVal, secondVal);
        }

        public BigInteger DivideBigIntegers(ref BigInteger firstVal, ref BigInteger secondVal)
        {
            return BigIntegers.DivideBigIntegers(ref firstVal, ref secondVal);
        }
    }

    
    public static class BigIntegers
    {
        public static BigInteger AddBigIntegers(BigInteger firstVal, BigInteger secondVal)
        {
            BigInteger result = firstVal + secondVal;
            return result;
        }

        public static BigInteger ExtractBigIntegers(BigInteger firstVal, BigInteger secondVal)
        {
            BigInteger result = firstVal - secondVal;
            return result;
        }

        public static BigInteger MultiplyBigIntegers(BigInteger firstVal, BigInteger secondVal)
        {
            BigInteger result = firstVal * secondVal;
            return result;
        }

        public static BigInteger DivideBigIntegers(ref BigInteger firstVal, ref BigInteger secondVal)
        {
            
                Console.Clear();
                Console.WriteLine("Your first value:");
                Console.WriteLine(firstVal);
                Console.WriteLine("Your second value:");
            Console.WriteLine(secondVal);
            return firstVal / secondVal;
        }
    }
}
