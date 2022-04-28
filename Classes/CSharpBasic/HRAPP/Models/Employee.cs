using System;
using HRAPP.Enum;

namespace HRAPP.Models
{
    public class Employee
    {
        public int ID{get; set;}
        
        public string Name{get; set;}
        public string ContactNo{get; set;}
        public DateTime JoiningDate{get; set;}
        public Gender Gender{get; set;}
    }
}