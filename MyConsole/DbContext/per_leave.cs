//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyConsole.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class per_leave
    {
        public int iLeave_ID { get; set; }
        public string cWorker_no { get; set; }
        public Nullable<System.DateTime> dFrom_date { get; set; }
        public Nullable<System.DateTime> dTo_Date { get; set; }
        public string creason_code { get; set; }
        public System.DateTime dAmend_Date { get; set; }
        public string cAmend_user { get; set; }
        public string cRemarks { get; set; }
    }
}
