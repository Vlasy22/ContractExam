namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractState")]
    public partial class ContractState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContractState()
        {
            Contracts = new HashSet<Contract>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDContractState { get; set; }

        [StringLength(6)]
        public string Code { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
