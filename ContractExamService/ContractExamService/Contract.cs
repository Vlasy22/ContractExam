namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            ContractXSubjects = new HashSet<ContractXSubject>();
        }

        [Key]
        public int IDContract { get; set; }

        [StringLength(30)]
        public string ContractCode { get; set; }

        public int? IDState { get; set; }

        public virtual ContractState ContractState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractXSubject> ContractXSubjects { get; set; }
    }
}
