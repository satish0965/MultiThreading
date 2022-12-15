using NUnit.Framework;

namespace MultithreadEmpPayroll
{
    public class Tests
    {
        EmployeePayRoll employeePayrollOperations;
        PayrollOperations payrollOperations;
        [SetUp]
        public void Setup()
        {
            employeePayrollOperations = new EmployeePayRoll();
            payrollOperations = new PayrollOperations();
        }
        /// <summary>
        /// UC-1 & 3
        /// </summary>
        [Test]
        public void Given10Employee_WhenAddToList_ShouldMatchEmployeeEntries()
        {
            List<EmpData> employees = new List<EmpData>();
            employees.Add(new EmpData(EmployeeID: 1, EmployeeName: "Eren", PhoneNumber: "8106529025", Address: "Attack On Titan", Department: "Survey Corpes", Gender: 'M', BasicPay: 25000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 24000, City: "shinsengumi", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 2, EmployeeName: "Levi", PhoneNumber: "8106523333", Address: "Attack On Titan", Department: "Captian", Gender: 'M', BasicPay: 250000, Deductions: 2000, TaxablePay: 2000, Tax: 1000, NetPay: 240000, City: "Wall Maria", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 3, EmployeeName: "Mikasa", PhoneNumber: "61065629025", Address: "Attack On Titan", Department: "Survey Corpes", Gender: 'f', BasicPay: 20000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 19000, City: "shinsengumi", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 4, EmployeeName: "Naruto", PhoneNumber: "8123429025", Address: "Naruto", Department: "Hokage", Gender: 'M', BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000, City: "Leaf Village", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 5, EmployeeName: "Sasuke", PhoneNumber: "9123429025", Address: "Naruto", Department: "Shadow Hokage", Gender: 'M', BasicPay: 500000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 490000, City: "Leaf Village", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 6, EmployeeName: "Madara", PhoneNumber: "8003429025", Address: "Naruto", Department: "Uchiha Head", Gender: 'M', BasicPay: 650000, Deductions: 500, TaxablePay: 1000, Tax: 10000, NetPay: 640000, City: "Uchiha Clan", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 7, EmployeeName: "Luffy", PhoneNumber: "8123429025", Address: "OnePiece", Department: "Pirate", Gender: 'M', BasicPay: 50000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000, City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 8, EmployeeName: "Zorro", PhoneNumber: "9123459025", Address: "OnePiece", Department: "Pirate Hunter", Gender: 'M', BasicPay: 40000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000, City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 9, EmployeeName: "Nami", PhoneNumber: "8123429025", Address: "OnePiece", Department: "Navigator", Gender: 'F', BasicPay: 460000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 45000, City: "Grand Blue", Country: "Anime"));
            employees.Add(new EmpData(EmployeeID: 10, EmployeeName: "Naruto", PhoneNumber: "8123429025", Address: "Naruto", Department: "Hokage", Gender: 'M', BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000, City: "Leaf Village", Country: "Anime"));

            employeePayrollOperations = new EmployeePayRoll();
            DateTime StartDateTime = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employees);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration Without thread: " + (stopDateTime - StartDateTime));

            //UC-2 & 3 With Thread
            DateTime StartDateTimeThread = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayrollWithThread(employees);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration With thread: " + (stopDateTime - StartDateTime));


        }
        [Test]
        //Test UC 4 & 5
        public void Given10employee_ShowDuration()
        {
            List<PayrollDetails> empPayRoll = new List<PayrollDetails>();
            empPayRoll.Add(new PayrollDetails(EmployeeID: 1, BasicPay: 25000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 24000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 2, BasicPay: 250000, Deductions: 2000, TaxablePay: 2000, Tax: 1000, NetPay: 240000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 3, BasicPay: 20000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 19000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 4, BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 5, BasicPay: 500000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 490000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 6, BasicPay: 650000, Deductions: 500, TaxablePay: 1000, Tax: 10000, NetPay: 640000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 7, BasicPay: 50000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 8, BasicPay: 40000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 9, BasicPay: 460000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 45000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 10, BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000));

            //Without Thread
            payrollOperations = new PayrollOperations();
            payrollOperations.addPayrollWithoutThread(empPayRoll);

            //With Thread
            payrollOperations.addPayrolllWithThread(empPayRoll);
        }
    }
}