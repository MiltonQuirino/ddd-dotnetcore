using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        private readonly Student _student;
        private readonly Subscription _subscription;
        private readonly Name _name;
        private readonly Document _document;
        private readonly Address _address;
        private readonly Email _email;

        public StudentTests()
        {
            _name = new Name("Bruce", "Wayne");
            _document = new Document("35383875832", Domain.Enums.EDocumentType.CPF);
            _email = new Email("bat@dc.com");
            _address = new Address("Av Paulista", "1299", "Bela Vista", "Sao Paulo", "São Paulo", "Brasil", "09564000");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);

        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var payment = new PayPalPayment("123456", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne", _document, _address, _email);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadSubscriptionHasNoPayment()
        {
            _student.AddSubscription(_subscription);
            Assert.IsTrue(_student.Invalid);
        }


        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {
            var payment = new PayPalPayment("123456", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne", _document, _address, _email);
            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Valid);
        }

    }
}