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
    
    public partial class per_room
    {
        public int iRoom_ID { get; set; }
        public string cHouse { get; set; }
        public string cRoom_no { get; set; }
        public int iCapacity { get; set; }
        public decimal nTotal_Chest { get; set; }
        public decimal nTotal_bed { get; set; }
        public decimal nTotal_bedstand { get; set; }
        public decimal nTotal_fanner { get; set; }
        public decimal nTotal_E_lamp { get; set; }
        public decimal nTotal_D_lamp { get; set; }
        public byte iSex { get; set; }
        public byte iType { get; set; }
        public string mRemarks { get; set; }
        public System.DateTime damend_date { get; set; }
        public string camend_user { get; set; }
        public byte[] msrepl_tran_version { get; set; }
    }
}
