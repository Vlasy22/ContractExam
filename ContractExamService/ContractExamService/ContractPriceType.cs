namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractPriceType")]
    public partial class ContractPriceType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractPriceType()
        {
            ContractPrices = new HashSet<ContractPrice>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDContractPriceType { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractPrice> ContractPrices { get; set; }
    }
}
