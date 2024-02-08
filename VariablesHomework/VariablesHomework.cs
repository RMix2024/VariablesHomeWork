using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VariablesHomework
{
    [TestClass]
    public class Variables
    {
        [TestMethod]
        public void Declaration()
        {
            int number = 25;
            bool boolean = true;
            double decimalValue = 99.9;
            float floatingDecimalValue = 25.4f;
            string words = "I am a programmer now";
            char character = 'z';

            Assert.IsTrue(number == 25); // Make this pass
            Assert.IsTrue(boolean == true); // Make this pass
            Assert.IsTrue(decimalValue == 99.9); // Make this pass
            Assert.IsTrue(floatingDecimalValue == 25.4f); // Make this pass
            Assert.IsTrue(words == "I am a programmer now"); // Make this pass
            Assert.IsTrue(character == 'z'); // Make this pass
        }

        [TestMethod]
        public void Assignment()
        {
            int i = 0;
            i = 25;
            Assert.IsTrue(i == 25); // Make this pass
            i = 100;
            Assert.IsTrue(i == 100); // Then make this pass

            float f = 0.0f;
            f = 3.5f;
            Assert.IsTrue(f == 3.5); // Make this pass
            f = 99.9f;
            Assert.IsTrue(f == 99.9f); // Then make this pass

            bool b = false;
            Assert.IsTrue(b = true); // Make this pass
            b = false;
            Assert.IsTrue(b == false); // Then make this pass

            double d = 0.0;
            d = 10.0;
            Assert.IsTrue(d == 10.0); // Make this pass
            d = 20.0;
            Assert.IsTrue(d == 20.0); // Then make this pass


            string s = "";
            s = "word";
            Assert.IsTrue(s == "word"); // Make this pass
            s = "next";
            Assert.IsTrue(s == "next"); // Then make this pass

            char c = 'a';
            c = 'b';
            Assert.IsTrue(c == 'b'); // Make this pass
            c = 'c';
            Assert.IsTrue(c == 'c'); // Then make this pass

            int z = i;
            Assert.IsTrue(z == 100/*Answer here*/); // Make this pass
        }

        // Refer to this if you need help 
        [TestMethod]
        public void Operators()
        {
            int a = 0;
            int b = a + 13;
            Assert.IsTrue(b == 13 /*Answer here*/); // Make this pass

            float f = 12.3f;
            float c = f - 7.43f;


            Assert.IsTrue(c == 4.8700004f/*Answer here*/); // Make this pass
            Assert.IsTrue(f == 12.3f/*Answer here*/); // Make this pass

            bool d = false;
            bool e = !d;

            Assert.IsTrue(e == !false/*Answer here*/); // Make this pass

            int anotherInt = 12;
            int g = -anotherInt;
            Assert.IsTrue(g == -12/*Answer here*/); // Make this pass

            int yetAnotherInt = 23456;
            int t = yetAnotherInt * 3;
            Assert.IsTrue(t == 23456 * 3/*Answer here*/); // Make this pass

            int z = 23456;
            z *= 3;
            Assert.IsTrue(z == 23456 * 3/*Answer here*/); // Make this pass

            int h = 23;
            h++;
            Assert.IsTrue(h == 24/*Answer here*/); // Make this pass
            h--;
            Assert.IsTrue(h == 23/*Answer here*/); // Make this pass
            ++h;
            Assert.IsTrue(h == 24/*Answer here*/); // Make this pass
            --h;
            Assert.IsTrue(h == 23/*Answer here*/); // Make this pass
            h += 1;
            Assert.IsTrue(h == 24/*Answer here*/); // Make this pass
            h -= 1;
            Assert.IsTrue(h == 23/*Answer here*/); // Make this pass

            string l = "Hello! ";
            string m = l + "You!";
            Assert.IsTrue(m == "Hello! You!"/*Answer here*/); // Make this pass

            int v = 5;
            int x = v % 4;
            System.Diagnostics.Debug.WriteLine(x);
            Assert.IsTrue(x == 1/*Answer here*/); // Make this pass

            int finalInt = 15;
            int divisionResult = 15 / 3;
            Assert.IsTrue(divisionResult == 5/*Answer here*/); // Make this pass

            finalInt = 15;
            finalInt /= 3;
            Assert.IsTrue(finalInt == 5/*Answer here*/); // Make this pass

            int orderOfOperations = 2;
            orderOfOperations = 2 + 12 * (orderOfOperations * 3);
            Assert.IsTrue(orderOfOperations == 74/*Answer here*/); // Make this pass
        }

        [TestMethod]
        public void Ranges()
        {
            Assert.IsTrue(int.MaxValue == 2147483647/*Answer here*/); // Make this pass

            Assert.IsTrue(int.MinValue == -2147483648/*Answer here*/); // Make this pass

            Assert.IsTrue(float.MaxValue == 3.40282347E+38f/*Answer here*/); // Make this pass

            Assert.IsTrue(float.MinValue == -3.40282347E+38f/*Answer here*/); // Make this pass

            Assert.IsTrue(double.MaxValue == 1.7976931348623158E+308/*Answer here*/); // Make this pass

            Assert.IsTrue(double.MinValue == -1.7976931348623158E+308/*Answer here*/); // Make this pass
        }

        [TestMethod]
        public void Overflow()
        {
            unchecked // ignore this, it simple means im telling the compiler i know what I am doing.
            {

                Assert.IsTrue(int.MaxValue + 1 == 2147483647 + 1/*Answer here*/); // Make this pass

                Assert.IsTrue(int.MinValue - 1 == -2147483648 - 1/*Answer here*/); // Make this pass

                Assert.IsTrue(float.MaxValue + 1 == float.MaxValue/*Answer here*/); // Make this pass

                Assert.IsTrue(float.MinValue - 1 == float.MinValue/*Answer here*/); // Make this pass

                Assert.IsTrue(double.MaxValue + 1 == 1.7976931348623158E+308 + 1/*Answer here*/); // Make this pass

                Assert.IsTrue(double.MinValue - 1 == -1.7976931348623157E+308 - 1/*Answer here*/); // Make this pass

                //Not sure what you are looking for here^^^^ the solutions are too large otherwise
            }
        }

        [TestMethod]
        public void Conversion()
        {
            int i = 13;
            double d = i;
            Assert.IsTrue(d == System.Convert.ToDouble(13)/*Answer here*/); // Make this pass 

            // Why does that compile andwork but this doesnt? (NOW IT WORKS)
            // Had to change variable so its not double utilized and utilized the Convert dot notation (I think thats what its called)
            double dd = 15.5;
            int c = System.Convert.ToInt32(dd);



        }

        [TestMethod]
        public void Casting()
        {
            // what am i doing here that make the above work? You casted the double as an INT
            double d = 15.5;
            int c = (int)d;
            Assert.IsTrue(c == (int)15.5/*Answer here*/); // Make this pass

            string e = d.ToString();
            Assert.IsTrue(e == d.ToString()/*Answer here*/); // Make this pass
        }

        [TestMethod]
        public void Parsing()
        {
            string a = "67";
            int b = int.Parse(a);
            Assert.IsTrue(b == 67/*Answer here*/); // Make this pass
        }
    }
}

//Change to make pull request.