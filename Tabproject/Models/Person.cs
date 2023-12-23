namespace Tabproject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public long Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(15)]
        public string NationalCode { get; set; }

        public long? Score { get; set; }

        public DateTime? RequestDate { get; set; }

        public bool? DecisionProposal { get; set; }
    }
}
