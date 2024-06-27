using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Collections.Generic;
using System.Collections;

namespace CoreSample.Model.ViewModel
{
    [Table("PatientDetails")]
    public class PatientDetailsMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Location { get; set; }
        public string? AdmittedLocation { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string? Profession { get; set; }

        public string? ContactNumber { get; set; }
        public string? ContactEmail { get; set; }
        public string? Address { get; set; }
        public string? PatientHistory { get; set; }
        public string? DepartmentID { get; set; }


    }


    [Table("Patients")]

    public class PatientsMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string? PatientID { get; set; }
        public string? PatientName { get; set; }
        public string? TreatmentStatus { get; set; }
    }

    [Table("Roles")]
    public class RolesMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
    }


    [Table("Users")]
    public class UsersMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int UserID { get; set; }
        public string? UserName { get; set; }
    }

    [Table("UserRoles")]
    public class UserRolesMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int UserRoleID { get; set; }
        public string? RoleID { get; set; }
        public string? UserID { get; set; }
        public string? Location { get; set; }


        public int Test()
        {

            IEnumerable<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };
            int i = 0;

           // numbers2.Add(10);   
           //Ienumerable does not have add method
            foreach (int number in numbers2)
            {
                i = i + number;

            }
            ICollection<int> obj = new HashSet<int> { 4, 5 };
          
            //int k = obj[0].Length;
            //ICollection cannot use Index
            foreach (int number in obj)
            {
                i = i + number;
            }

            IList<string> EmployeeName = new List<string>();

            EmployeeName.Add("Rahul");
            EmployeeName.Add("Pragya");
            EmployeeName.Add("Chinmay");
            EmployeeName.Add("Priya");

           // EmployeeName.Add(1);

            int j = EmployeeName[0].Length;

            //Ienumerable is faster than IList, Ienumerable can restrict modifying the list of items

            ArrayList arrayl = new ArrayList();
            arrayl.Add(1);
            arrayl.Add("TEST");


            //Array[int] a = new { 1, 2, 3, 4, 5 };
            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = [1, 2, 3, 4, 5, 6];

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = [1, 2, 3, 4];

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            return 0;

        }
    }

}
