﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace gogobuy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gogobuydbEntities : DbContext
    {
        public gogobuydbEntities()
            : base("name=gogobuydbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tCollection> tCollection { get; set; }
        public virtual DbSet<tMembership> tMembership { get; set; }
        public virtual DbSet<tOrder> tOrder { get; set; }
        public virtual DbSet<tOrderDetails> tOrderDetails { get; set; }
        public virtual DbSet<tProduct> tProduct { get; set; }
        public virtual DbSet<tProductDetails> tProductDetails { get; set; }
        public virtual DbSet<tShopping> tShopping { get; set; }
        public virtual DbSet<tShoppingDetails> tShoppingDetails { get; set; }
        public virtual DbSet<tWishProduct> tWishProduct { get; set; }
        public virtual DbSet<tProductImage> tProductImage { get; set; }
    }
}
