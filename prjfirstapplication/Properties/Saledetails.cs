using System;
using System.Collections.Generic;
using System.Text;

namespace Day1assignment
{
    class Saledetails
    {
        int Salesno;
        int Productno;
        double Price;
        DateTime dateofsale;
        int Qty;
        
        Saledetails(int Salesno, int Productno, double Price, DateTime dateofsale, int Qty)
        {
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.Price = Price;
            this.dateofsale = dateofsale;
            this.Qty = Qty;
        }
        void Sales(int qty, double price)
        {
            double TotalAmount = qty * price;
            Console.WriteLine("Total Amount : {0}", TotalAmount);
        }

        void show_data()
        {
            Console.WriteLine("Sale no:{0} || Product no:{1} || Price:{2}  || Date of Sale :{3} || Quantity :{4}",Salesno,Productno,Price,(dateofsale).ToString("dd/MM/yyyy"),Qty);
        }

        public static void Main(String[] args)
        {
            Saledetails s1 = new Saledetails(1, 101, 10000, Convert.ToDateTime("25/12/1999"), 200);

            s1.show_data();
            s1.Sales(2, 60.5);
        }
    }
}