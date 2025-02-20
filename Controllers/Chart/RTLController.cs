﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EJ2CoreSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        public IActionResult RTL()
        {
            List<RTLChartData> chartData = new List<RTLChartData>
            {
                new RTLChartData { Year= 2016, Sales= 1000, Expense= 400, Profit= 600},
                new RTLChartData { Year= 2017, Sales= 970, Expense= 360, Profit= 610},
                new RTLChartData { Year= 2018, Sales= 1060, Expense= 920, Profit= 140},
                new RTLChartData { Year= 2019, Sales= 1030, Expense= 540, Profit= 490},
            };
            ViewBag.dataSource = chartData;
            return View();
        }
        public class RTLChartData
        {
            public double Year;
            public double Sales;
            public double Expense;
            public double Profit;
        }
    }
}
