//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanSach.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ImportDetails = new HashSet<ImportDetail>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int ProductID { get; set; }
        public string Product_Name { get; set; }
        public Nullable<int> TopicID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string Image { get; set; }
        public Nullable<double> Price_Import { get; set; }
        public Nullable<double> Price_Export { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> IsNew { get; set; }
        public Nullable<int> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportDetail> ImportDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Topic Topic { get; set; }
    }
}
