﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace osm2mssql.InfoDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class osm2Entities : DbContext
    {
        public osm2Entities()
            : base("name=osm2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tNode> tNode { get; set; }
        public DbSet<tNodeTag> tNodeTag { get; set; }
        public DbSet<tTagType> tTagType { get; set; }
    }
}
