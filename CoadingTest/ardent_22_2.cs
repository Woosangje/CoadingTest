﻿using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
namespace ardent_21_02 {
    //문제 21-1 알파벳 반전
    
    class Employee {
        public string name;
        public string pid;
        public int salary;

        public string Name(string name) {
            return this.name = name;
        }
        public string Pid(string pid) {
            return this.pid = pid;
        }

        public int Salary(int salary) {
            return this.salary = salary;
        }

    }
    class MainApp {

        static void Main(string[] args) {

            List<Employee> arr = new List<Employee>();

            for(int i=0; i<3; i++) {
                Write("이름: ");
                arr[i].Name
                Write("주민번호: ");
                arr[i].Pid(ReadLine());
                Write("급여: ");
                arr[i].Salary(int.Parse(ReadLine()));
            }

            for(int i=0; i<3; i++) {

                WriteLine("이름: {0}", arr[i].name);
                WriteLine("주민번호: {0}", arr[i].pid);
                WriteLine("급여: {0}", arr[i].salary);
            }
        }

    }
}

