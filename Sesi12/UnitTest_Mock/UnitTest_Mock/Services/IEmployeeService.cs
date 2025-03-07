﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTest_Mock.Models;

namespace UnitTest_Mock.Services
{
    public interface IEmployeeService
    {
        Task<string> GetEmployeebyId(int empID);
        Task<Employee> GetEmployeeDetails(int empID);
    }
}
