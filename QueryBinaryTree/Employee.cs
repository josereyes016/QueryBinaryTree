﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBinaryTree
{
    class Employee : IComparable<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return String.Format("Id: {0}, Name: {1} {2}, Dept: {3}", this.Id, this.FirstName, this.LastName, this.Department);
        }
    }

}
