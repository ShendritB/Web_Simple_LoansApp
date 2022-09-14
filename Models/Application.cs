using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_UshtrimePerProvim_LoansApp.Models
{
    public partial class Application
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public decimal LoanAmount { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; } = null!;
    }
}
