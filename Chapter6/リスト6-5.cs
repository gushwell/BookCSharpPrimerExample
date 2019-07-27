using System;
using System.Collections.Generic;

namespace PolySample {
    public class CustomerManager {
        public void ReRank(List<CustomerInfo> list) {
            foreach (CustomerInfo cust in list) {
                Rank r = cust.Rank;
                cust.Rank = r.NextRank(cust);
            }
        }

        public double DiscountRate(CustomerInfo cust) {
            Rank r = cust.Rank;
            return r.DiscountRate(cust);
        }
    }
}
