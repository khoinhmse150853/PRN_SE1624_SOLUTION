using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_SE1624_OOP
{
    public class Employee
    {
        //Define fields (data)
        private int _id;
        private string _name;
        private DateTime _dob;

        //Define Properities
        public float Salary { get; set; }
        public string Level { get; set; }
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Dob { get => _dob; set => _dob = value; }
        public Employee()
        {
        }

        public Employee(float salary, string level, int id, string name, DateTime dob)
        {
            Salary = salary;
            Level = level;
            Id = id;
            Name = name;
            Dob = dob;
        }

        public override string? ToString()
        {
            return GetString();
        }

        private string GetString()
        {
            return $"[Id = {this._id}, Name = {Name}, Dob = {this._dob}], Level = {Level}, Salary = {Salary}";
        }

        //manual method

    }
}
