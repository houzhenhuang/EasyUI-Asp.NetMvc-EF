//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonnelEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkExperience
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
        public string WorkDepartment { get; set; }
        public string ProfessionalTitle { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public string Content { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}