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
    using System.ComponentModel;

    public partial class all_beacons
    {
        [DisplayName("ID")]
        public int idb { get; set; }
        public Nullable<double> x { get; set; }
        public Nullable<double> y { get; set; }
        public string comments { get; set; }
        public Nullable<decimal> last_seen { get; set; }
        public Nullable<long> neighbourID { get; set; }
    
        public virtual active_beacons active_beacons { get; set; }
        public virtual new_beacons new_beacons { get; set; }
    }
}
