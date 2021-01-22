using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingBillingSystem
{
    public class Payment
    {
        public string Id
        {
            get => default;
            set
            {
            }
        }

        public string Payment_Method
        {
            get => default;
            set
            {
            }
        }

        public DateTime Paid_date
        {
            get => default;
            set
            {
            }
        }

        public string Details
        {
            get => default;
            set
            {
            }
        }

        public string Card_Number
        {
            get => default;
            set
            {
            }
        }

        public Shopping_Cart Paid_by
        {
            get => default;
            set
            {
            }
        }

        public PaymentValidator ValidatedBy
        {
            get => default;
            set
            {
            }
        }

        public int Total
        {
            get => default;
            set
            {
            }
        }

        public void MakePayment()
        {
            throw new System.NotImplementedException();
        }
    }
}