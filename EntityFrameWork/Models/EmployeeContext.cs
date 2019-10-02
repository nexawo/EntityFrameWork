using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    // Inherit EmployeeContext with DbContext Class which Comes from 
    //Microsoft.EntityFrameworkCore
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base (options)
        {

        }

        public DbSet<Employee> Employees { get; set; }



        public void RowCount(Employee rc)
        {
            var EmpName = new SqlParameter("@empName", rc.EmployeeName);
            this.Database.ExecuteSqlCommand("exec RowCounts @empName", EmpName);
        }
    }
}
