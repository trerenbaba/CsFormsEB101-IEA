//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsFormsEB102_Ana.OgrenciIsleri.OgrEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOgrenciBilgileri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tcno { get; set; }
        public string OgrNo { get; set; }
        public Nullable<int> BolumId { get; set; }
        public Nullable<int> SehirId { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual tblDepartments tblDepartments { get; set; }
        public virtual tblSehirler tblSehirler { get; set; }
    }
}
