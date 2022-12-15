using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadEmpPayroll
{
    public class EmployeePayRoll
    {
        public List<EmpData> employeePolyeeDetailList = new List<EmpData>();

        //UC 1 & 3
        public void addEmployeeToPayroll(List<EmpData> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Stopwatch Time = new Stopwatch();
                Time.Start();
                Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Time.Stop();
                Console.WriteLine("Employee added : " + employeeData.EmployeeName + " ( Duration  : " + Time.Elapsed + ")");
            });
            Console.WriteLine(this.employeePolyeeDetailList.ToString());
        }
        //UC 2 & 3
        public void addEmployeeToPayrollWithThread(List<EmpData> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    //For Every iterarion of foreach loop, every record will get in to thread, every thread will be
                    //running in a single process to make execution quick and fast.
                    Stopwatch Time = new Stopwatch();
                    Time.Start();

                    Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Time.Stop();
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName + " ( Duration : " + Time.Elapsed + ")");
                });
                thread.Start();
            });
            Console.WriteLine(this.employeePolyeeDetailList.Count);
        }
        public void addEmployeeToPayroll(EmpData emp)
        {
            employeePolyeeDetailList.Add(emp);
        }
    }
}