namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Individual")]
    public partial class Individual
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Individual()
        {
            ContractXSubjects = new HashSet<ContractXSubject>();
        }

        [Key]
        public int IDIndividual { get; set; }

        [StringLength(50)]
        public string CustomerCode { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(12)]
        public string Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        public string NationalID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractXSubject> ContractXSubjects { get; set; }
    }
}
