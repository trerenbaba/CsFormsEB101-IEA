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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentsEntities : DbContext
    {
        public StudentsEntities()
            : base("name=StudentsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblDepartments> tblDepartments { get; set; }
        public virtual DbSet<tblOgrenciBilgileri> tblOgrenciBilgileri { get; set; }
        public virtual DbSet<tblSehirler> tblSehirler { get; set; }
    }
}
