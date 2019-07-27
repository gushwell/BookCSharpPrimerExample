using System;
using System.Collections.Generic;

namespace InterfaceSample {

    public class CustomerInfo {
        public string Id { get; set; }
        public string Name { get; set; }
        public int MonthlySales { get; set; }
        public DateTime AddmissionDate { get; set; }
        public IRank Rank { get; set; }
    }

    public interface IRank {
        IRank NextRank(CustomerInfo cust);
        double DiscountRate(CustomerInfo cust);
    }

    public class RankA : IRank {
        public IRank NextRank(CustomerInfo cust) {
            if (cust.MonthlySales > 1000000)
                return this;
            else
                return new RankB();
        }
        public double DiscountRate(CustomerInfo cust) {
            bool overthree = DateTime.Today > cust.AddmissionDate.AddYears(3);
            if (overthree)
                return 0.08;
            else
                return 0.05;
        }
    }

    public class RankB : IRank {
        public IRank NextRank(CustomerInfo cust) {
            if (cust.MonthlySales > 1000000)
                return new RankA();
            else if (cust.MonthlySales > 500000)
                return this;
            else
                return new RankC();
        }

        public double DiscountRate(CustomerInfo cust) {
            bool overthree = DateTime.Today > cust.AddmissionDate.AddYears(3);
            if (overthree)
                return 0.03;
            else
                return 0.02;
        }
    }

    public class RankC : IRank {
        public IRank NextRank(CustomerInfo cust) {
            if (cust.MonthlySales > 500000)
                return new RankB();
            else
                return this;
        }

        public double DiscountRate(CustomerInfo cust) {
            bool overthree = DateTime.Today > cust.AddmissionDate.AddYears(3);
            if (overthree)
                return 0.01;
            else
                return 0.00;
        }
    }

    public class CustomerManager {
        public static void ReRank(List<CustomerInfo> list) {
            foreach (CustomerInfo cust in list) {
                IRank r = cust.Rank;
                cust.Rank = r.NextRank(cust);
            }
        }

        public static double DiscountRate(CustomerInfo cust) {
            IRank r = cust.Rank;
            return r.DiscountRate(cust);
        }

    }

}
