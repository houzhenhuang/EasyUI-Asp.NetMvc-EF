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
    
    public partial class Role
    {
        public Role()
        {
            this.RoleMenuButton = new HashSet<RoleMenuButton>();
            this.UserRole = new HashSet<UserRole>();
        }
    
        public int Id { get; set; }
        public string RoleName { get; set; }
        public System.DateTime AddDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<RoleMenuButton> RoleMenuButton { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
