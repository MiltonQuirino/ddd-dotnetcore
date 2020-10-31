using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {

        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var document = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(document.Invalid);

        }

        [TestMethod]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var document = new Document("11309434000194", EDocumentType.CNPJ);
            Assert.IsTrue(document.Valid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var document = new Document("35375832", EDocumentType.CPF);
            Assert.IsTrue(document.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("35383875832")]
        [DataRow("95483875437")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var document = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(document.Valid);
        }

    }
}