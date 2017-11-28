using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using iHRIS.Entities;
using System.Diagnostics;

namespace iHRIS.Api_Controller
{
    public class MstEmployeeOtherIncomeController : ApiController
    {
        private Data.iHRIS_WebDataContext db = new Data.iHRIS_WebDataContext();

        [HttpGet,Route("api/employeeotherincome/list")]
        public List<MstEmployeeOtherIncome> mstEmployeeOtherIncome()
        {
            var EmployeeOtherIncome = from d in db.MstEmployeeOtherIncomes
                                      select new Entities.MstEmployeeOtherIncome
                                      {
                                          Id = d.Id,
                                          EmployeeId = d.EmployeeId,
                                          OtherIncomeId = d.OtherIncomeId,
                                          Amount = d.Amount,
                                          Remarks = d.Remarks
                                      };
            return EmployeeOtherIncome.ToList();
        }
    }
}
