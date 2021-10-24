namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractDate")]
    public partial class ContractDate
    {
        [Key]
        public int IDContractDate { get; set; }

        public int? IDContract { get; set; }

        public int? ContractDateType { get; set; }

        public DateTime? Date { get; set; }

        public virtual ContractDateType ContractDateType1 { get; set; }
    }
}
