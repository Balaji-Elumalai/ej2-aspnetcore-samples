﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;
using Syncfusion.EJ2.QueryBuilder;

namespace EJ2CoreSampleBrowser.Controllers.QueryBuilder
{
    public partial class QueryBuilderController : Controller
    {
        public IActionResult ComplexDatabinding()
        {
            QueryBuilderRule rule = new QueryBuilderRule()
            {
                Condition = "and",
                Rules = new List<QueryBuilderRule>()
                {
                    new QueryBuilderRule { Label="ID", Field="Employee.ID", Type="number", Operator="equal", Value = 1001 },
                    new QueryBuilderRule { Label="First Name", Field="Name.FirstName", Type="string", Operator="equal", Value = "Mark" },
                    new QueryBuilderRule { Condition="or", Rules = new List<QueryBuilderRule>() {
                        new QueryBuilderRule { Label="State", Field="Country.State", Type="string", Operator="equal", Value = "Jersey" },
                        new QueryBuilderRule { Label="Date of birth", Field="Employee.DOB", Type="date", Operator="equal", Value = "7/7/96" }
                    }}
                }
            };
            ViewBag.rule = rule;
            return View();
        }
    }
}