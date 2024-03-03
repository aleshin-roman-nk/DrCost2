using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entity
{
    // переименуем в payment-sample
    public class PaymentSample
    {
        public int id { get; set; }
        public string? name { get; set; }
        public PaymentCategory? category { get; set; }
        public FindingTag findingTag { get; set; }
    }
}
