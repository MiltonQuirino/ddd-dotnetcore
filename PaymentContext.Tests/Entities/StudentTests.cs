using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void addSubscribe()
        {
            // var subscription = new Subscription();
            // var student = new Student("MTN", "QRN", "4545454", "eu@gmaili.com");
            // student.AddSubscription(subscription);

            var name = new Name("Teste", "Teste");
            foreach (var not in name.Notifications)
            {
                // not.Message;git
            }
        }

    }
}