//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Module2
//{
//    class Calculator
//    {
//       public  double cost { get; set; }
//        public double orderPrice { get; set; }

//        public double tax { get; set; }

//        public double deliveryCharge { get; set; }
//        public double totalCost;

//        public Calculator(double cost, double orderPrice, double tax, double deliveryCharge)
//        {
//            this.cost = cost;
//            this.orderPrice = orderPrice;
//            this.tax = tax;
//            this.deliveryCharge = deliveryCharge;
//        }

     

//        public double compute(int totalNumber)
//        {
//            this.orderPrice = totalNumber * this.cost;
//            this.tax = this.orderPrice * 12 / 100;
//            this.deliveryCharge = this.orderPrice < 1000 ? 250 : 0;
//            this.totalCost = orderPrice + tax + deliveryCharge;
//            return totalCost;
//        }
//    }

//    class M2_Activity_2D
//    {
//        static void Main(string[] args)
//        {
//            Calculator apples = new Calculator(50, 0, 0, 0);

           
//            Console.Write("How many apples do you want to order? ");
//            int totalNumber = Convert.ToInt32(Console.ReadLine());

//            double totalCost = apples.compute(totalNumber);

//            Console.WriteLine($"Order Price: P{String.Format("{0:0.00}", apples.orderPrice)}");
//            Console.WriteLine($"Tax: P{String.Format("{0:0.00}", apples.tax)}");
//            Console.WriteLine($"Delivery Charge: P{String.Format("{0:0.00}", apples.deliveryCharge)}");
//            Console.WriteLine($"TOTAL: P{String.Format("{0:0.00}",apples.totalCost)}");

//            Console.ReadLine();
//        }

//    }
//}
