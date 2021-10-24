namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubjectRole")]
    public partial class SubjectRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubjectRole()
        {
            ContractXSubjects = new HashSet<ContractXSubject>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDSubjectRole { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractXSubject> ContractXSubjects { get; set; }
    }
}
