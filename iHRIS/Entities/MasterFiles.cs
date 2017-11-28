using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iHRIS.Entities
{
   public class MstBranch
    {
        public Int32 Id { get; set; }
        public String Branch { get; set; }
        public Int32 CompanyId { get; set; }
    }
    public class MstCompany
    {
        public Int32 Id { get; set; }
        public String Company { get; set; }
        public String Address { get; set; }
        public String SSSNumber { get; set; }
        public String PHICNumber { get; set; }
        public String HDMFNumber { get; set; }
        public String TIN { get; set; }
        public Int32 EntryUserId { get; set; }
        public DateTime EntryDateTime { get; set; }
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public Boolean IsLocked { get; set; }
    }
    public class MstDepartMent
    {
        public Int32 Id { get; set; }
        public String Department { get; set; }

    }
    public class MstDivision
    {
        public Int32 Id { get; set; }
        public String Division { get; set; }
    }
    public class MstPosition
    {
        public Int32 Id { get; set; }
        public String Position { get; set; }
    }
    public class MstReligion
    {
        public Int32 Id { get; set; }
        public String Religion { get; set; }
    }
    public class MstAccount
    {
        public Int32 Id { get; set; }
        public String AccountCode { get; set; }
        public String Account { get; set; }
    }
    public class MstPayrollGroup
    {
        public Int32 Id { get; set; }
        public String PayrollGroup { get; set; }
    }
    public class MstPayrollType
    {
        public Int32 Id { get; set; }
        public String PayrollType { get; set; }

    }
    public class MstZipCode
    {
        public Int32 Id { get; set; }
        public String ZipCode { get; set; }
        public String Location { get; set; }
        public String Area { get; set; }
    }
    public class MstTaxCode
    {
        public Int32 Id { get; set; }
        public String TaxCode { get; set; }
        public Decimal ExemptionAmount { get; set; }
        public Decimal DependentAmount { get; set; }
    }
}
