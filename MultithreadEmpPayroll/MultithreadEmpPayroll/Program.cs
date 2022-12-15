// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadEmpPayroll
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Multi Threading Problem");
        }
    }
}

//With Thread Process The Employees details are not added as sequential manner.
/*
Standard Output: 
Payment Being Added  :25000, Deduction Added : 200 ,TaxablePay Added : 200, Tax Added : 100, NetPay Added : 24000
Payment added : 25000, Deduction Added : 200 ,TaxablePay Added : 200, Tax Added : 100, NetPay Added : 24000 ( Duration  : 00:00:00.0006808)
Payment Being Added  :250000, Deduction Added : 2000 ,TaxablePay Added : 2000, Tax Added : 1000, NetPay Added : 240000
Payment added : 250000, Deduction Added : 2000 ,TaxablePay Added : 2000, Tax Added : 1000, NetPay Added : 240000 ( Duration  : 00:00:00.0000027)
Payment Being Added  :20000, Deduction Added : 200 ,TaxablePay Added : 200, Tax Added : 100, NetPay Added : 19000
Payment added : 20000, Deduction Added : 200 ,TaxablePay Added : 200, Tax Added : 100, NetPay Added : 19000 ( Duration  : 00:00:00.0000018)
Payment Being Added  :550000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 540000
Payment added : 550000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 540000 ( Duration  : 00:00:00.0000014)
Payment Being Added  :500000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 490000
Payment added : 500000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 490000 ( Duration  : 00:00:00.0000020)
Payment Being Added  :650000, Deduction Added : 500 ,TaxablePay Added : 1000, Tax Added : 10000, NetPay Added : 640000
Payment added : 650000, Deduction Added : 500 ,TaxablePay Added : 1000, Tax Added : 10000, NetPay Added : 640000 ( Duration  : 00:00:00.0000015)
Payment Being Added  :50000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 40000
Payment added : 50000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 40000 ( Duration  : 00:00:00.0000014)
Payment Being Added  :40000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 40000
Payment added : 40000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 40000 ( Duration  : 00:00:00.0000013)
Payment Being Added  :460000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 45000
Payment added : 460000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 45000 ( Duration  : 00:00:00.0000014)
Payment Being Added  :550000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 540000
Payment added : 550000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 540000 ( Duration  : 00:00:00.0000014)
System.Collections.Generic.List`1[MultithreadEmpPayroll.PayrollDetails]
10
Basic Added  : 25000, Deduction Added : 200 ,TaxablePay Added : 200, Tax Added : 100, NetPay Added : 24000
Basic added : 25000, Deduction Added : 200 ,TaxablePay Added : 200, Tax Added : 100, NetPay Added : 24000 ( Duration : 00:00:00.0000092)
Basic Added  : 40000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 40000
Basic added : 40000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 40000 ( Duration : 00:00:00.0000021)
Basic Added  : 460000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 45000
Basic added : 460000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 45000 ( Duration : 00:00:00.0000015)
Basic Added  : 550000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 540000
Basic Added  : 550000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 540000
Basic Added  : 250000, Deduction Added : 2000 ,TaxablePay Added : 2000, Tax Added : 1000, NetPay Added : 240000
Basic added : 550000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 540000 ( Duration : 00:00:00.0000172)
Basic Added  : 500000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 490000
Basic added : 250000, Deduction Added : 2000 ,TaxablePay Added : 2000, Tax Added : 1000, NetPay Added : 240000 ( Duration : 00:00:00.0000175)
Basic Added  : 650000, Deduction Added : 500 ,TaxablePay Added : 1000, Tax Added : 10000, NetPay Added : 640000
Basic added : 500000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 490000 ( Duration : 00:00:00.0000099)
Basic added : 650000, Deduction Added : 500 ,TaxablePay Added : 1000, Tax Added : 10000, NetPay Added : 640000 ( Duration : 00:00:00.0000060)
Basic added : 550000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 540000 ( Duration : 00:00:00.0000014)
Basic Added  : 20000, Deduction Added : 200 ,TaxablePay Added : 200, Tax Added : 100, NetPay Added : 19000
Basic Added  : 50000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 40000
Basic added : 20000, Deduction Added : 200 ,TaxablePay Added : 200, Tax Added : 100, NetPay Added : 19000 ( Duration : 00:00:00.0000060)
Basic added : 50000, Deduction Added : 300 ,TaxablePay Added : 100, Tax Added : 100, NetPay Added : 40000 ( Duration : 00:00:00.0000035)
 */