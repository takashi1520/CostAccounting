//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CostAccounting
{
    using System;
    using System.Collections.Generic;
    
    [Serializable] public partial class RowMaterial
    {
        public string code { get; set; }
        public int year { get; set; }
        public string name { get; set; }
        public decimal price_budget { get; set; }
        public decimal price_actual { get; set; }
        public string note { get; set; }
        public string update_user { get; set; }
        public System.DateTime update_date { get; set; }
        public string del_flg { get; set; }
    }
}
