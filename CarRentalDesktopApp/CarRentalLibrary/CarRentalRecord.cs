//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalDesktopApp.CarRentalLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarRentalRecord
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> DateRented { get; set; }
        public Nullable<System.DateTime> DateToReturn { get; set; }
        public Nullable<System.DateTime> DateReturned { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> CarID { get; set; }
    
        public virtual CarRecord CarRecord { get; set; }
    }
}
