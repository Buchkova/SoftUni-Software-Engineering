﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Name: {this.Name}, Age: {this.Age} ");
            return stringBuilder.ToString();
        }
    }
}
