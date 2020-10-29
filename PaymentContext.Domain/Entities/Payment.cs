namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {

        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Address { get; set; }
    }

    public class BoletoPayment : Payment
    {

    }
    public class CreditCardPayment : Payment
    {
        public string Email { get; set; }
        public int MyProperty { get; set; }
    }
    public class PayPalPayment : Payment
    {
        public string Email { get; set; }
        public int MyProperty { get; set; }
    }
}