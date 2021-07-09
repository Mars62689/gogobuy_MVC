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
    
    public partial class tProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tProduct()
        {
            this.tCollection = new HashSet<tCollection>();
            this.tOrderDetails = new HashSet<tOrderDetails>();
            this.tProductDetails = new HashSet<tProductDetails>();
            this.tShoppingDetails = new HashSet<tShoppingDetails>();
            this.tProductImage = new HashSet<tProductImage>();
        }
    
        public int fProductID { get; set; }
        public string fCategory { get; set; }
        public string fProductName { get; set; }
        public Nullable<decimal> fPrice { get; set; }
        public Nullable<int> fQuantity { get; set; }
        public string fImgPath { get; set; }
        public string fDescription { get; set; }
        public Nullable<int> fMemberID { get; set; }
        public string fProductLocation { get; set; }
        public string fArrivalTime { get; set; }
        public Nullable<System.DateTime> fUpdateTime { get; set; }
        public Nullable<bool> fIsWish { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tCollection> tCollection { get; set; }
        public virtual tMembership tMembership { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tOrderDetails> tOrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tProductDetails> tProductDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tShoppingDetails> tShoppingDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tProductImage> tProductImage { get; set; }
    }
}
