using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iHRIS.Entities
{
    public class MstEmployeeMemo
    {
        public Int32 Id { get; set; }
        public Int32 EmployeeId { get; set; }
        public DateTime MemoDate { get; set; }
        public String MemoSubject { get; set; }
        public String MemoContent { get; set; }
        public Int32 PreparedBy { get; set; }
        public Int32 ApprovedBy { get; set; }
    }
    public class MstEmployeeShiftCode
    {
        public Int32 Id { get; set; }
        public Int32 EmployeeId { get; set; }
        public Int32 ShiftCodeId { get; set; }
    }
    public class MstEmployeeOtherIncome
    {
        public Int32 Id { get; set; }
        public Int32 EmployeeId { get; set; }
        public Int32 OtherIncomeId { get; set; }
        public Decimal Amount { get; set; }
        public String Remarks { get; set; }
    }
    public class MstEmployee
    {
        public Int32 Id { get; set; }
        public String IdNumber { get; set; }
        public String BiometricIdNumber { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String ExtensionName { get; set; }
        public String FullName { get; set; }
        public String Address { get; set; }
        public Int32 ZipCodeId { get; set; }
        public String PhoneNumber { get; set; }
        public String CellphoneNumber { get; set; }
        public String EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String PlaceOfBirth { get; set; }
        public Int32? PlaceOfBirthZipCodeId { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime? DateResigned { get; set; }
        public String Sex { get; set; }
        public String CivilStatus { get; set; }
        public Int32 CitizinshipId { get; set; }
        public Int32 ReligionId { get; set; }
        public Decimal Height { get; set; }
        public Decimal Weight { get; set; }
        public String GSISNumber { get; set; }
        public String SSSNumber { get; set; }
        public String HDMFNumber { get; set; }
        public String PHICNumber { get; set; }
        public String TIN { get; set; }
        public Int32 TaxCodeId { get; set; }
        public String ATMAccountNumber { get; set; }
        public Int32 CompanyId { get; set; }
        public Int32 BranchId { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int32 DivisionId { get; set; }
        public Int32 PositionId { get; set; }
        public Int32 PayrollGroupId { get; set; }
        public Int32 AccountId { get; set; }
        public Int32 PayrollTypeId { get; set; }
        public Int32 ShiftCodeId { get; set; }
        public Int32 FixNumberOfDays { get; set; }
        public Int32 FixNumberOfHours { get; set; }
        public Decimal MonthlyRate { get; set; }
        public Decimal PayrollRate { get; set; }
        public Decimal DailyRate { get; set; }
        public Decimal AbsentDailyRate { get; set; }
        public Decimal HourlyRate { get; set; }
        public Decimal NightHourlyRate { get; set; }
        public Decimal OvertimeHourlyRate { get; set; }
        public Decimal OvertimeNightHourlyRate { get; set; }
        public Decimal TardyHourlyRate { get; set; }
        public Int32 EntryUserId { get; set; }
        public DateTime EntryDateTime { get; set; } 
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public Boolean IsLocked { get; set; }
        public String TaxTable { get; set; }
        public Decimal? HDMFAddOn { get; set; }
        public Decimal? SSSAdOn { get; set; }
        public String HDMFType { get; set; }
        public Boolean SSSIsGrossAmount { get; set; }
        public Boolean? IsMinimumWageEarner { get; set; }
    }
}