namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractDateType")]
    public partial class ContractDateType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractDateType()
        {
            ContractDates = new HashSet<ContractDate>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDContractDateType { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractDate> ContractDates { get; set; }
    }
}
