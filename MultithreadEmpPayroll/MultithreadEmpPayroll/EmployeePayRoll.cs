using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadEmpPayroll
{
    public class EmployeePayRoll
    {
        public List<EmpData> employeePolyeeDetailList = new List<EmpData>();

        //UC 1
        public void addEmployeeToPayroll(List<EmpData> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added : " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeePolyeeDetailList.ToString());
        }
        //UC 2
        public void addEmployeeToPayrollWithThread(List<EmpData> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    //For Every iterarion of foreach loop, every record will get in to thread, every thread will be
                    //running in a single process to make execution quick and fast.

                    Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName);
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