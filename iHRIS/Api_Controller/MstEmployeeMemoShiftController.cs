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
    public class MstEmployeeMemoShiftController : ApiController
    {
        private Data.iHRIS_WebDataContext db = new Data.iHRIS_WebDataContext();

        /// 
        ///  EMPLOYEE MEMO  
        /// 

        [HttpGet,Route("api/employeememo/list")]
        public List<MstEmployeeMemo> MstEmployeeMemo()
        {
            var EmployeeMemo = from d in db.MstEmployeeMemos
                               select new Entities.MstEmployeeMemo
                               {
                                   Id=d.Id,
                                   EmployeeId=d.EmployeeId,
                                   MemoDate=d.MemoDate,
                                   MemoSubject=d.MemoSubject,
                                   MemoContent=d.MemoContent,
                                   PreparedBy=d.PreparedBy,
                                   ApprovedBy=d.ApprovedBy
                               };
            return EmployeeMemo.ToList();
        }

        ///
        ///  EMPLOYEE SHIFT CODE
        ///
        [HttpGet,Route("api/employeeshift/list")]
        public List<MstEmployeeShiftCode> MstEmployeeShift()
        {
            var EmployeeShift = from d in db.MstEmployeeShiftCodes
                                select new Entities.MstEmployeeShiftCode
                                {
                                    Id = d.Id,
                                    EmployeeId = d.EmployeeId,
                                    ShiftCodeId = d.ShiftCodeId
                                };
            return EmployeeShift.ToList();
        }
    }
}
