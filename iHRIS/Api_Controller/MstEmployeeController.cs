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
    public class MstEmployeeController : ApiController
    {
        private Data.iHRIS_WebDataContext db = new Data.iHRIS_WebDataContext();

        [HttpGet,Route("api/employee/list")]
        public List<MstEmployee> MstEmployee()
        {
            var Employee = from d in db.MstEmployees
                           select new Entities.MstEmployee
                           {
                               Id=d.Id,
                               IdNumber=d.IdNumber,
                               BiometricIdNumber=d.BiometricIdNumber,
                               LastName=d.LastName,
                               FirstName=d.FirstName,
                               MiddleName=d.MiddleName,
                               ExtensionName=d.ExtensionName,
                               FullName=d.FullName,
                               Address=d.Address,
                               ZipCodeId=d.ZipCodeId,
                               PhoneNumber=d.PhoneNumber,
                               CellphoneNumber=d.CellphoneNumber,
                               EmailAddress=d.EmailAddress,
                               DateOfBirth=d.DateOfBirth,
                               PlaceOfBirth=d.PlaceOfBirth,
                               PlaceOfBirthZipCodeId=d.PlaceOfBirthZipCodeId,
                               DateHired=d.DateHired,
                               DateResigned=d.DateResigned,
                               Sex=d.Sex,
                               CivilStatus=d.CivilStatus,
                               CitizinshipId=d.CitizenshipId,
                               ReligionId=d.ReligionId,
                               Height=d.Height,
                               Weight=d.Weight,
                               GSISNumber=d.GSISNumber,
                               SSSNumber=d.SSSNumber,
                               HDMFNumber=d.HDMFNumber,
                               PHICNumber=d.PHICNumber,
                               TIN=d.TIN,
                               TaxCodeId=d.TaxCodeId,
                               ATMAccountNumber=d.ATMAccountNumber,
                               CompanyId=d.CompanyId,
                               BranchId=d.BranchId,
                               DepartmentId=d.DepartmentId,
                               DivisionId=d.DivisionId,
                               PositionId=d.PositionId,
                               PayrollGroupId=d.PayrollGroupId,
                               AccountId=d.AccountId,
                               PayrollTypeId=d.PayrollTypeId,
                               ShiftCodeId=d.ShiftCodeId,
                               FixNumberOfDays=d.FixNumberOfDays,
                               FixNumberOfHours=d.FixNumberOfHours,
                               MonthlyRate=d.MonthlyRate,
                               PayrollRate=d.PayrollRate,
                               DailyRate=d.DailyRate,
                               AbsentDailyRate=d.AbsentDailyRate,
                               HourlyRate=d.HourlyRate,
                               NightHourlyRate=d.NightHourlyRate,
                               OvertimeHourlyRate=d.OvertimeHourlyRate,
                               OvertimeNightHourlyRate=d.OvertimeNightHourlyRate,
                               TardyHourlyRate=d.TardyHourlyRate,
                               EntryUserId=d.EntryUserId,
                               EntryDateTime=d.EntryDateTime,
                               UpdateUserId=d.UpdateUserId,
                               UpdateDateTime=d.UpdateDateTime,
                               IsLocked=d.IsLocked,
                               TaxTable=d.TaxTable,
                               HDMFAddOn=d.HDMFAddOn,
                               SSSAdOn=d.SSSAddOn,
                               HDMFType=d.HDMFType,
                               SSSIsGrossAmount=d.SSSIsGrossAmount,
                               IsMinimumWageEarner=d.IsMinimumWageEarner
                           };
            return Employee.ToList();
        }
       [HttpGet, Route("api/employee/detail/{id}")]
       public Entities.MstEmployee EmployeeList(string id)
        {
            var EmployeeDetails = from d in db.MstEmployees
                                  where d.Id == Convert.ToInt32(id)
                                  select new MstEmployee
                                  {
                                      Id = d.Id,
                                      IdNumber = d.IdNumber,
                                      BiometricIdNumber = d.BiometricIdNumber,
                                      LastName = d.LastName,
                                      FirstName = d.FirstName,
                                      MiddleName = d.MiddleName,
                                      ExtensionName = d.ExtensionName,
                                      FullName = d.FullName,
                                      Address = d.Address,
                                      ZipCodeId = d.ZipCodeId,
                                      PhoneNumber = d.PhoneNumber,
                                      CellphoneNumber = d.CellphoneNumber,
                                      EmailAddress = d.EmailAddress,
                                      DateOfBirth = d.DateOfBirth,
                                      PlaceOfBirth = d.PlaceOfBirth,
                                      PlaceOfBirthZipCodeId = d.PlaceOfBirthZipCodeId,
                                      DateHired = d.DateHired,
                                      DateResigned = d.DateResigned,
                                      Sex = d.Sex,
                                      CivilStatus = d.CivilStatus,
                                      CitizinshipId = d.CitizenshipId,
                                      ReligionId = d.ReligionId,
                                      Height = d.Height,
                                      Weight = d.Weight,
                                      GSISNumber = d.GSISNumber,
                                      SSSNumber = d.SSSNumber,
                                      HDMFNumber = d.HDMFNumber,
                                      PHICNumber = d.PHICNumber,
                                      TIN = d.TIN,
                                      TaxCodeId = d.TaxCodeId,
                                      ATMAccountNumber = d.ATMAccountNumber,
                                      CompanyId = d.CompanyId,
                                      BranchId = d.BranchId,
                                      DepartmentId = d.DepartmentId,
                                      DivisionId = d.DivisionId,
                                      PositionId = d.PositionId,
                                      PayrollGroupId = d.PayrollGroupId,
                                      AccountId = d.AccountId,
                                      PayrollTypeId = d.PayrollTypeId,
                                      ShiftCodeId = d.ShiftCodeId,
                                      FixNumberOfDays = d.FixNumberOfDays,
                                      FixNumberOfHours = d.FixNumberOfHours,
                                      MonthlyRate = d.MonthlyRate,
                                      PayrollRate = d.PayrollRate,
                                      DailyRate = d.DailyRate,
                                      AbsentDailyRate = d.AbsentDailyRate,
                                      HourlyRate = d.HourlyRate,
                                      NightHourlyRate = d.NightHourlyRate,
                                      OvertimeHourlyRate = d.OvertimeHourlyRate,
                                      OvertimeNightHourlyRate = d.OvertimeNightHourlyRate,
                                      TardyHourlyRate = d.TardyHourlyRate,
                                      EntryUserId = d.EntryUserId,
                                      EntryDateTime = d.EntryDateTime,
                                      UpdateUserId = d.UpdateUserId,
                                      UpdateDateTime = d.UpdateDateTime,
                                      IsLocked = d.IsLocked,
                                      TaxTable = d.TaxTable,
                                      HDMFAddOn = d.HDMFAddOn,
                                      SSSAdOn = d.SSSAddOn,
                                      HDMFType = d.HDMFType,
                                      SSSIsGrossAmount = d.SSSIsGrossAmount,
                                      IsMinimumWageEarner = d.IsMinimumWageEarner
                                  };
            return (Entities.MstEmployee)EmployeeDetails.FirstOrDefault();
        }
        //add
        [HttpPost,Route("api/employee/add")]
        public int postEmployee(MstEmployee addEmployee)
        {
            try
            {
                Data.MstEmployee newEmployee = new Data.MstEmployee();


                db.MstEmployees.InsertOnSubmit(newEmployee);
                db.SubmitChanges();
                return newEmployee.Id;
            }
            catch
            {
                return 0;
            }
        }
        //Delete
        [HttpDelete,Route("api/employee/delete/{Id}")]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                var EmployeeDetails = from d in db.MstEmployees
                                      where d.Id == Convert.ToInt32(id) select d;
                if (EmployeeDetails.Any())
                {
                    if (!EmployeeDetails.FirstOrDefault().IsLocked)
                    {
                        db.MstEmployees.DeleteOnSubmit(EmployeeDetails.First());
                        db.SubmitChanges();

                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

    }
}
