//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class account
    {
        public string id { get; set; }
        public int balance { get; set; }
        public string fk_user_id { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
        public Nullable<System.DateTime> date_updated { get; set; }
    
        public virtual user user { get; set; }
    }
}
