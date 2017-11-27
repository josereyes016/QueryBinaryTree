﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BinaryTree;

namespace QueryBinaryTree
{
    class Program
    {
        static void doWork()
        {
            // Construct and Populate an instance of the BinaryTree class
            Tree<Employee> empTree = new Tree<Employee>(
                new Employee { Id = 1, FirstName = "Kim", LastName = "Amercrombire", Department = "IT" });

            empTree.Insert(new Employee { Id = 2, FirstName = "Jeff", LastName = "Hay", Department = "Marketing" });
            empTree.Insert(new Employee { Id = 4, FirstName = "Charlie", LastName = "Herb", Department = "IT" });
            empTree.Insert(new Employee { Id = 6, FirstName = "Chris", LastName = "Preston", Department = "Sales" });
            empTree.Insert(new Employee { Id = 3, FirstName = "Dave", LastName = "Barnett", Department = "Sales" });
            empTree.Insert(new Employee { Id = 5, FirstName = "Tim", LastName = "Litton", Department = "Marketing" });

            Console.WriteLine("List of departments");
            var depts = empTree.Select(d => d.Department).Distinct();
            foreach (var dept in depts)
            {
                Console.WriteLine("Department: {0}", dept);
            }

            Console.WriteLine("\nEmployees in the IT department");
            var ITEmployees = empTree.Where(e => String.Equals(e.Department, "IT")).Select(emp => emp);
            foreach (var emp in ITEmployees)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("\nAll employees grouped by department");
            var employeesByDept = empTree.GroupBy(e => e.Department);
            foreach (var dept in employeesByDept)
            {
                Console.WriteLine("Department: {0}", dept.Key);
                foreach (var emp in dept)
                {
                    Console.WriteLine("\t{0} {1}", emp.FirstName, emp.LastName);
                }
            }

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
