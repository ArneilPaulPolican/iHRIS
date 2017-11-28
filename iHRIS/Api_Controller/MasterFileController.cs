using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using System.Diagnostics;
using iHRIS.Entities;

namespace iHRIS.Api_Controller
{
    public class MasterFileController : ApiController
    {
        private Data.iHRIS_WebDataContext db = new Data.iHRIS_WebDataContext();

        //===================================================================================
        //
        //                 Master File List API
        //
        //===================================================================================
        [HttpGet, Route("api/branch/list")]
        public List<MstBranch> MstBranch()
        {
            var brach = from d in db.MstBranches
                        select new Entities.MstBranch
                        {
                            Id = d.Id,
                            Branch = d.Branch,
                            CompanyId = d.CompanyId
                        };
            return brach.ToList();
        }
        [HttpGet, Route("api/company/list")]
        public List<MstCompany> MstCompany()
        {
            var comapny = from d in db.MstCompanies
                          select new Entities.MstCompany
                          {
                              Id = d.Id,
                              Company = d.Company,
                              Address = d.Address,
                              SSSNumber = d.SSSNumber,
                              PHICNumber = d.PHICNumber,
                              HDMFNumber = d.HDMFNumber,
                              TIN = d.TIN,
                              EntryUserId = d.EntryUserId,
                              EntryDateTime = d.EntryDateTime,
                              UpdateUserId = d.UpdateUserId,
                              UpdateDateTime = d.UpdateDateTime,
                              IsLocked = d.IsLocked
                          };
            return comapny.ToList();
        }
        [HttpGet, Route("api/department/list")]
        public List<MstDepartMent> MstDepartment()
        {
            var department = from d in db.MstDepartments
                             select new Entities.MstDepartMent
                             {
                                 Id = d.Id,
                                 Department = d.Department
                             };
            return department.ToList();
        }
        [HttpGet, Route("api/division/list")]
        public List<MstDivision> MstDivision()
        {
            var division = from d in db.MstDivisions
                           select new Entities.MstDivision
                           {
                               Id = d.Id,
                               Division = d.Division
                           };
            return division.ToList();
        }
        [HttpGet, Route("api/position/list")]
        public List<MstPosition> MstPosition()
        {
            var position = from d in db.MstPositions
                           select new Entities.MstPosition
                           {
                               Id = d.Id,
                               Position = d.Position
                           };
            return position.ToList();
        }
        [HttpGet, Route("api/religion/list")]
        public List<MstReligion> MstReligion()
        {
            var religion = from d in db.MstReligions
                           select new Entities.MstReligion
                           {
                               Id = d.Id,
                               Religion = d.Religion
                           };
            return religion.ToList();
        }
        [HttpGet, Route("api/account/list")]
        public List<MstAccount> MstAccount()
        {
            var account = from d in db.MstAccounts
                          select new Entities.MstAccount
                          {
                              Id = d.Id,
                              AccountCode = d.AccountCode,
                              Account = d.Account
                          };
            return account.ToList();
        }
        [HttpGet, Route("api/payrollgroup/list")]
        public List<MstPayrollGroup> MstPayrollGroup()
        {
            var payrollgroup = from d in db.MstPayrollGroups
                               select new Entities.MstPayrollGroup
                               {
                                   Id = d.Id,
                                   PayrollGroup = d.PayrollGroup
                               };
            return payrollgroup.ToList();
        }
        [HttpGet, Route("api/payrolltype/list")]
        public List<MstPayrollType> MstPayrollType()
        {
            var payrolltype = from d in db.MstPayrollTypes
                              select new Entities.MstPayrollType
                              {
                                  Id = d.Id,
                                  PayrollType = d.PayrollType
                              };
            return payrolltype.ToList();
        }
        [HttpGet,Route("api/zipcode/list")]
        public List<MstZipCode> MstZipCode()
        {
            var zipcode = from d in db.MstZipCodes
                          select new Entities.MstZipCode
                          {
                              Id = d.Id,
                              ZipCode = d.ZipCode,
                              Location = d.Location,
                              Area = d.Area
                          };
            return zipcode.ToList();
        }
        [HttpGet,Route("api/taxcode/list")]
        public List<MstTaxCode> MstTaxCode()
        {
            var taxcode = from d in db.MstTaxCodes
                          select new Entities.MstTaxCode
                          {
                              Id = d.Id,
                              TaxCode = d.TaxCode,
                              ExemptionAmount = d.ExemptionAmount,
                              DependentAmount = d.DependentAmount
                          };
            return taxcode.ToList();
        }
    }
}
