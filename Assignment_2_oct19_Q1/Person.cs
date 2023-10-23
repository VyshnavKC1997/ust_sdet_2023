﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class Person
    {
        string? firstName;
        string? lastName;
        int age;

        public Person(string? firstName, string? lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string? FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string? LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get {
             
                    return age;
                
            }
            set {
                if (value >= 18 && value <= 100)
                    age = value;
                else
                    Console.WriteLine("Age should be greater than 18 and less than 100");
            }
        }


    }
}
