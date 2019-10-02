using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "This Field is Required.")]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Employee Code")]
        public string EmployeeCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }

        [DisplayName("Office Number")]
        [Column(TypeName = "nvarchar(20)")]
        public string OfficeNumber { get; set; }

        [Required(ErrorMessage = "Mobile number is required.")]
        [DisplayName("Mobile Number")]
        [Column(TypeName = "nvarchar(20)")]
        
        public string MobileNumber { get; set; }

        public void getAll()
        {

        }
    }
}
