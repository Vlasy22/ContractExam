namespace ContractExamService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContractPrice")]
    public partial class ContractPrice
    {
        [Key]
        public int IDContractPrice { get; set; }

        public int? IDContract { get; set; }

        public int? IDContractPriceType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Value { get; set; }

        public int? IDCurrency { get; set; }

        public virtual ContractPriceType ContractPriceType { get; set; }

        public virtual Currency Currency { get; set; }
    }
}
