//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warden_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class notifications
    {
        public int idn { get; set; }
        public int idb { get; set; }
        public string ntype { get; set; }
        public string ninfo { get; set; }
        public long time { get; set; }
    
        public virtual active_beacons active_beacons { get; set; }
    }
}