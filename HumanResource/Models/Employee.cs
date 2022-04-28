using System.ComponentModel.DataAnnotations;

namespace HumanResources.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ContactNumber { get; set; }

        public DateTime JoiningDate { get; set; }
        public Gender Gender { get; set; }

        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

    }
    public enum Gender
    {
        Male = 1,
        Female = 2,
        Other = 3
    }

}
