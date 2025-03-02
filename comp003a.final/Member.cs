using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.final
{
    internal class Member
    {
        /// <summary>
        /// the name of the member 
        /// </summary>
        public string name;
        /// <summary>
        /// the age of the member 
        /// </summary>
        public int age;
        /// <summary>
        /// the plan of the member (basic/premium)
        /// </summary>
        public string plan;

        /// <summary>
        /// create a new member
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Age"></param>
        /// <param name="Plan"></param>
        public Member(string Name, int Age, string Plan)
        {
            Name = name;
            Age = age;
            Plan = plan;
        }
        /// <summary>
        /// displays member details
        /// </summary>
        public void display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Plan: {plan}");
        }


    }
}
