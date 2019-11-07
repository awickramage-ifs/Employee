using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Model;

namespace Employee.Data.EFCore
{
    public class EfCorEmpRepository : EfCoreRepository<Emp,EmployeeContext>
    {
        public EfCorEmpRepository(EmployeeContext context) : base(context)
        {
        }
    }
}
