//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HFtable
    {
        public int id { get; set; }
        public string hfNR { get; set; }
        public string hfZZ { get; set; }
        public int uID { get; set; }
        public int gtId { get; set; }
        public Nullable<int> newId { get; set; }
    
        public virtual GTtable GTtable { get; set; }
        public virtual Login Login { get; set; }
        public virtual newOne newOne { get; set; }
    }
}
