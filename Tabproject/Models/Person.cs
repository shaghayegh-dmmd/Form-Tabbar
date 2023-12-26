namespace Tabproject.Models
{
    using System;
    using System.Collections.Generic;
using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
       
        public long Id { get; set; }

        [StringLength(150)]
        [DisplayName("نام")]
        public string Name { get; set; }

        [StringLength(150)]
        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }

        [StringLength(15)]
        [DisplayName("کدملی")]
        public string NationalCode { get; set; }
        [DisplayName("امتیاز")]
        public long? Score { get; set; }
        [DisplayName("تاریخ پیگیری")]
        public DateTime? RequestDate { get; set; }
        [DisplayName("پیشنهاد تصمیم")]
        public bool? DecisionProposal { get; set; }
    }
}
