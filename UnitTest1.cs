using StudentServiceLib;
using System.Security.Principal;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Student st = new Student();
            
            st.Score = 10;
            // Assert
            
            Assert.AreEqual(st.getLetterScore(), 'A');
        }

     
        [TestMethod]
        public void TestMethod2()
        {

            Student st = new Student();

            st.Score = 7.9;
            // Assert

            Assert.AreEqual(st.getLetterScore(), 'B');
        }
        [TestMethod]
        public void TestMethod3()
        {

            Student st = new Student();

            st.Score = 5.1;
            // Assert

            Assert.AreEqual(st.getLetterScore(), 'C');
        }
        [TestMethod]
        public void TestMethod4()
        {

            Student st = new Student();

            st.Score = 3.6;
            // Assert

            Assert.AreEqual(st.getLetterScore(), 'D');
        }
        [TestMethod]
        public void TestMethod5()
        {

            Student st = new Student();

            st.Score = 3.2;
            // Assert

            Assert.AreEqual(st.getLetterScore(), 'E');
        }

        [TestMethod]
        public void higher()
        {
            Student st = new Student();
            if (st.Score > 10){
                throw new SystemException("Score must not exeed 10.0");
            }

        }

        [TestMethod]
        public void TestMethod6()
        {
            Student st = new Student();
            String ErrorHigherthan10 = "Score must not exeed 10.0";
            String message = null;
            try
            {
                st.Score = 20;
            }catch(SystemException e)
            {
                message = e.Message;
            }
            Assert.AreEqual(ErrorHigherthan10 , higher);

        }
    }
}