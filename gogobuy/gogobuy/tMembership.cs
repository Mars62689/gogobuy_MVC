//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tMembership
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tMembership()
        {
            this.tCollection = new HashSet<tCollection>();
            this.tOrder = new HashSet<tOrder>();
            this.tOrder1 = new HashSet<tOrder>();
            this.tProduct = new HashSet<tProduct>();
            this.tShopping = new HashSet<tShopping>();
            this.tWishProduct = new HashSet<tWishProduct>();
        }
    
        public int fMemberID { get; set; }
        public string fFirstName { get; set; }
        public string fLastName { get; set; }
        public string fAddress { get; set; }
        public string fEmail { get; set; }
        public string fPhone { get; set; }
        public Nullable<System.DateTime> fDateOfBirth { get; set; }
        public Nullable<bool> fGender { get; set; }
        public Nullable<bool> fEmailVerified { get; set; }
        public string fPassword { get; set; }
        public string fSalt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tCollection> tCollection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOrder> tOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOrder> tOrder1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tProduct> tProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tShopping> tShopping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tWishProduct> tWishProduct { get; set; }
    }
}
