using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employee.Model;
using Employee.Models;
using Employee.Data;
using Employee.Data.EFCore;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : Emps1Controller<Emp, EfCorEmpRepository>
    {
        public EmpsController(EfCorEmpRepository repository) : base(repository)
        {

        }

    }
}