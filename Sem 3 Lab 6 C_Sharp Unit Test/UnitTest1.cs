using Microsoft.VisualStudio.TestTools.UnitTesting;
using FracNumLib;

namespace Sem_3_Lab_6_C_Sharp_Unit_Test
{
    //public class FracNumCompare : FracNum
    //{
    //    FracNumCompare()
    //    {

    //    }

    //    public bool Equals(ref FracNum obj1, ref FracNum obj2)
    //    {
    //        if (((obj1 == null) || !this.GetType().Equals(obj1.GetType()))||(((obj2 == null) || !this.GetType().Equals(obj2.GetType()))))
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            return (obj1.GetNumerator() == obj2.GetNumerator())&&(obj2.GetDenominator()==obj2.GetDenominator());
    //        }
    //    }
    //}

    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Sum()
        {
            FracNum a = new(2, 3), b= new(4, 5), sum= new(22, 15);
            bool Num_eq = ((a+b).GetNumerator()==sum.GetNumerator());
            bool Denum_eq = ((a+b).GetDenominator()==sum.GetDenominator());
            bool Eq = true;
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new ( -15,1 ); sum = new ( -71,5 );
            Num_eq = ((a + b).GetNumerator() == sum.GetNumerator());
            Denum_eq = ((a + b).GetDenominator() == sum.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new ( 0,5 );
            Num_eq = ((a + b).GetNumerator() == b.GetNumerator());
            Denum_eq = ((a + b).GetDenominator() == b.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);



            int x = 5;
            a = new(2, 3); sum = new ( 17,3 );
            Num_eq = ((a + x).GetNumerator() == sum.GetNumerator());
            Denum_eq = ((a + x).GetDenominator() == sum.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(-15, 1); sum = new(-10,1 );
            Num_eq = ((a + x).GetNumerator() == sum.GetNumerator());
            Denum_eq = ((a + x).GetDenominator() == sum.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(0,5 ); sum = new(5,1 );
            Num_eq = ((a + x).GetNumerator() == sum.GetNumerator());
            Denum_eq = ((a + x).GetDenominator() == sum.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

        }

        [TestMethod]
        public void Sub()
        {
            FracNum a= new(2, 3), b = new(4, 5), sub = new(-2, 15);
            bool Num_eq = ((a-b).GetNumerator()==sub.GetNumerator());
            bool Denum_eq = ((a-b).GetDenominator()==sub.GetDenominator());
            bool Eq = true;
            Assert.AreEqual(Eq, Num_eq && Denum_eq);


            a = new(-7, 9 ); sub = new ( -71,45 );
            Num_eq = ((a - b).GetNumerator() == sub.GetNumerator());
            Denum_eq = ((a-b).GetDenominator()==sub.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(0, 2); sub = new(-4,5 );
            Num_eq = ((a - b).GetNumerator() == sub.GetNumerator());
            Denum_eq = ((a - b).GetDenominator() == sub.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);



            int x = 5;
            a = new(2, 3 ); sub = new ( -13,3 );
            Num_eq = ((a - x).GetNumerator() == sub.GetNumerator());
            Denum_eq = ((a - x).GetDenominator() == sub.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new ( -7, 9 ); sub = new(-52,9 );
            Num_eq = ((a - x).GetNumerator() == sub.GetNumerator());
            Denum_eq = ((a - x).GetDenominator() == sub.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(0, 2 ); sub = new(-5,1 );
            Num_eq = ((a - x).GetNumerator() == sub.GetNumerator());
            Denum_eq = ((a - x).GetDenominator() == sub.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);
        }

        [TestMethod]
        public void Mul()
        {
            FracNum a = new(2, 3), b = new (4, 5), mul = new(8, 15);
            bool Num_eq = ((a*b).GetNumerator()==mul.GetNumerator());
            bool Denum_eq = ((a*b).GetDenominator()==mul.GetDenominator());
            bool Eq = true;
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(-7, 9 ); mul = new ( -28,45 );
            Num_eq = ((a*b).GetNumerator()==mul.GetNumerator());
            Denum_eq = ((a*b).GetDenominator()==mul.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(0, 2 ); mul = new(0,1 );
            Num_eq = ((a * b).GetNumerator() == mul.GetNumerator());
            Denum_eq = ((a * b).GetDenominator() == mul.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);



            int x = 5;
            a = new(2,3 ); mul = new(10, 3 );
            Num_eq = ((a * x).GetNumerator() == mul.GetNumerator());
            Denum_eq = ((a * x).GetDenominator() == mul.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(-7, 9 ); mul = new(-35,9 );
            Num_eq = ((a * x).GetNumerator() == mul.GetNumerator());
            Denum_eq = ((a * x).GetDenominator() == mul.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(0, 2 ); mul = new(0,1 );
            Num_eq = ((a * x).GetNumerator() == mul.GetNumerator());
            Denum_eq = ((a * x).GetDenominator() == mul.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);
        }

        [TestMethod]
        public void Div()
        {
            FracNum a = new (2, 3), b = new (4, 5), div = new (5, 6);
            bool Num_eq = ((a/b).GetNumerator()==div.GetNumerator());
            bool Denum_eq = ((a/b).GetDenominator()==div.GetDenominator());
            bool Eq = true;
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(7, 9 ); div = new ( 35,36 );
            Num_eq = ((a/b).GetNumerator()==div.GetNumerator());
            Denum_eq = ((a/b).GetDenominator()==div.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new ( 0, 2 ); div = new(0,1 );
            Num_eq = ((a / b).GetNumerator() == div.GetNumerator());
            Denum_eq = ((a / b).GetDenominator() == div.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);



            int x = 5;
            a = new(2,3 ); div = new(2,15 );
            Num_eq = ((a / x).GetNumerator() == div.GetNumerator());
            Denum_eq = ((a / x).GetDenominator() == div.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(7, 9 ); div = new(7,45 );
            Num_eq = ((a / x).GetNumerator() == div.GetNumerator());
            Denum_eq = ((a / x).GetDenominator() == div.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(0, 2 ); div = new(0,1 );
            Num_eq = ((a / x).GetNumerator() == div.GetNumerator());
            Denum_eq = ((a / x).GetDenominator() == div.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);
        }

        [TestMethod]
        public void Pow()
        {
            int x = 2;
            FracNum a = new(2, 3), power = new(4, 9);
            bool Num_eq = ((a^x).GetNumerator()==power.GetNumerator());
            bool Denum_eq = ((a^x).GetDenominator()==power.GetDenominator());
            bool Eq = true;
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(-7, 9 ); power = new(49,81 );
            Num_eq = ((a ^ x).GetNumerator() == power.GetNumerator());
            Denum_eq = ((a^x).GetDenominator()==power.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            a = new(0, 2 ); power = new ( 0,1 );
            Num_eq = ((a ^ x).GetNumerator() == power.GetNumerator());
            Denum_eq = ((a ^ x).GetDenominator() == power.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);



            x = -1;
            a = new(3, 11 ); power = new(11,3 );
            Num_eq = ((a ^ x).GetNumerator() == power.GetNumerator());
            Denum_eq = ((a ^ x).GetDenominator() == power.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);

            x = 0;
            a = new(3, 11 ); power = new(1,1 );
            Num_eq = ((a ^ x).GetNumerator() == power.GetNumerator());
            Denum_eq = ((a ^ x).GetDenominator() == power.GetDenominator());
            Assert.AreEqual(Eq, Num_eq && Denum_eq);
        }

    }

    [TestClass]
    public class Logic
    {
        [TestMethod]
        public void More()
        {
            FracNum a = new(2, 3), b = new(4, 5);
            bool result = false;
            Assert.AreEqual((a > b), result);
            a = new(5, 6); b = new(5, 6); result = false;
            Assert.AreEqual((a > b), result);
            a = new ( 4,5 ); b = new ( 2,3 ); result = true;
            Assert.AreEqual((a > b), result);
        }

        [TestMethod]
        public void MoE()
        {
            FracNum a = new(2, 3), b = new(4, 5);
            bool result = false;
            Assert.AreEqual((a >= b), result);
            a = new(5, 6); b = new(5, 6); result = true;
            Assert.AreEqual((a >= b), result);
            a = new(4, 5); b = new(2, 3); result = true;
            Assert.AreEqual((a >= b), result);
        }

        [TestMethod]
        public void Equal()
        {
            FracNum a = new(2, 3), b = new(4, 5);
            bool result = false;
            Assert.AreEqual((a == b), result);
            a = new(5, 6); b = new(5, 6); result = true;
            Assert.AreEqual((a == b), result);
            a = new(4, 5); b = new(2, 3); result = false;
            Assert.AreEqual((a == b), result);
        }

        [TestMethod]
        public void NEqual()
        {
            FracNum a = new(2, 3), b = new(4, 5);
            bool result = true;
            Assert.AreEqual((a != b), result);
            a = new(5, 6); b = new(5, 6); result = false;
            Assert.AreEqual((a != b), result);
            a = new(4, 5); b = new(2, 3); result = true;
            Assert.AreEqual((a != b), result);
        }
        
        [TestMethod]
        public void LoE()
        {
            FracNum a = new(2, 3), b = new(4, 5);
            bool result = true;
            Assert.AreEqual((a <= b), result);
            a = new(5, 6); b = new(5, 6); result = true;
            Assert.AreEqual((a <= b), result);
            a = new(4, 5); b = new(2, 3); result = false;
            Assert.AreEqual((a <= b), result);
        }
        
        [TestMethod]
        public void Less()
        {
            FracNum a = new(2, 3), b = new(4, 5);
            bool result = true;
            Assert.AreEqual((a < b), result);
            a = new(5, 6); b = new(5, 6); result = false;
            Assert.AreEqual((a < b), result);
            a = new(4, 5); b = new(2, 3); result = false;
            Assert.AreEqual((a < b), result);
        }
    }
}