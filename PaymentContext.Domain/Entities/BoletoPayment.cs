using System;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            int barCode,
            int boletoNumber,
            string transactionCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            string document,
            string address,
            string email) : base(
                paidDate,
                expireDate,
                total,
                totalPaid,
                payer,
                document,
                address,
                email
            )
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public int BarCode { get; private set; }
        public int BoletoNumber { get; private set; }

    }
}