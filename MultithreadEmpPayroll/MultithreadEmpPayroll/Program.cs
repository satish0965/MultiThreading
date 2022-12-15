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
Employee Being Added :Eren
Employee added : Eren ( Duration  : 00:00:00.0003938)
Employee Being Added :Levi
Employee added : Levi ( Duration  : 00:00:00.0000007)
Employee Being Added :Mikasa
Employee added : Mikasa ( Duration  : 00:00:00.0000003)
Employee Being Added :Naruto
Employee added : Naruto ( Duration  : 00:00:00.0000002)
Employee Being Added :Sasuke
Employee added : Sasuke ( Duration  : 00:00:00.0000009)
Employee Being Added :Madara
Employee added : Madara ( Duration  : 00:00:00.0000003)
Employee Being Added :Luffy
Employee added : Luffy ( Duration  : 00:00:00.0000002)
Employee Being Added :Zorro
Employee added : Zorro ( Duration  : 00:00:00.0000002)
Employee Being Added :Nami
Employee added : Nami ( Duration  : 00:00:00.0000005)
Employee Being Added :Naruto
Employee added : Naruto ( Duration  : 00:00:00.0000002)
System.Collections.Generic.List`1[MultithreadEmpPayroll.EmpData]
Duration Without thread: 00:00:00.0008998
10
Duration With thread: 00:00:00.0008998
Employee Being Added :Luffy
Employee added : Luffy ( Duration : 00:00:00.0003222)
Employee Being Added :Eren
Employee Being Added :Zorro
Employee added : Zorro ( Duration : 00:00:00.0000012)
Employee Being Added :Nami
Employee added : Nami ( Duration : 00:00:00.0000003)
Employee Being Added :Naruto
Employee added : Eren ( Duration : 00:00:00.0003626)
Employee added : Naruto ( Duration : 00:00:00.0000017)
Employee Being Added :Levi
Employee added : Levi ( Duration : 00:00:00.0003370)
Employee Being Added :Naruto
Employee added : Naruto ( Duration : 00:00:00.0003452)
Employee Being Added :Mikasa
Employee added : Mikasa ( Duration : 00:00:00.0003420)
Employee Being Added :Sasuke
Employee added : Sasuke ( Duration : 00:00:00.0004017)
Employee Being Added :Madara
Employee added : Madara ( Duration : 00:00:00.0004014)
 */
