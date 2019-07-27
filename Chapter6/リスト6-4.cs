using System;

namespace PolySample {

    public class CustomerInfo {
        public string Id { get; set; }
        public string Name { get; set; }
        public int MonthlySales { get; set; }
        public DateTime AddmissionDate { get; set; }
        public Rank Rank { get; set; }
    }

    public abstract class Rank {
        public abstract Rank NextRank(CustomerInfo cust);
        public abstract double DiscountRate(CustomerInfo cust);
    }

    public class RankA : Rank {
        public override Rank NextRank(CustomerInfo cust) {
            if (cust.MonthlySales > 1000000)
                return this;
            else
                return new RankB();
        }
        public override double DiscountRate(CustomerInfo cust) {
            bool overthree = DateTime.Today > cust.AddmissionDate.AddYears(3);
            if (overthree)
                return 0.08;
            else
                return 0.05;
        }
    }

    public class RankB : Rank {
        public override Rank NextRank(CustomerInfo cust) {
            if (cust.MonthlySales > 1000000)
                return new RankA();
            else if (cust.MonthlySales > 500000)
                return this;
            else
                return new RankC();
        }

        public override double DiscountRate(CustomerInfo cust) {
            bool overthree = DateTime.Today > cust.AddmissionDate.AddYears(3);
            if (overthree)
                return 0.03;
            else
                return 0.02;
        }
    }

    public class RankC : Rank {
        public override Rank NextRank(CustomerInfo cust) {
            if (cust.MonthlySales > 500000)
                return new RankB();
            else
                return this;
        }

        public override double DiscountRate(CustomerInfo cust) {
            bool overthree = DateTime.Today > cust.AddmissionDate.AddYears(3);
            if (overthree)
                return 0.01;
            else
                return 0.00;
        }
    }

}
