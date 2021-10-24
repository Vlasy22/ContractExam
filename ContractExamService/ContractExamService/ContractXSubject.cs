namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractXSubject")]
    public partial class ContractXSubject
    {
        [Key]
        public int IDContractSubject { get; set; }

        public int? IDContract { get; set; }

        public int? IDIndividual { get; set; }

        public int? IDSubjectRole { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Individual Individual { get; set; }

        public virtual SubjectRole SubjectRole { get; set; }
    }
}
