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
    
    public partial class ChangeAudit
    {
        public int Id { get; set; }
        public Nullable<bool> Status { get; set; }
        public System.DateTime AuditTime { get; set; }
        public string Description { get; set; }
    
        public virtual Change Change { get; set; }
        public virtual Employee Employee { get; set; }
    }
}