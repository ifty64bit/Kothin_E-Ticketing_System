//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Train
    {
        public Train()
        {
            this.Manage_Trains = new HashSet<Manage_Trains>();
            this.Train_Compartments = new HashSet<Train_Compartments>();
        }
    
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    
        public virtual ICollection<Manage_Trains> Manage_Trains { get; set; }
        public virtual ICollection<Train_Compartments> Train_Compartments { get; set; }
        public virtual Train Trains1 { get; set; }
        public virtual Train Train1 { get; set; }
    }
}
