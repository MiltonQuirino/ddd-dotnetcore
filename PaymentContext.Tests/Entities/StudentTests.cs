using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void testMethod1()
        {
            var student = new Student("MTN", "QRN", "4545454", "eu@gmaili.com");

        }

    }
}