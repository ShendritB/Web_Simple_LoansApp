using System;
using System.Collections.Generic;

namespace Web_UshtrimePerProvim_LoansApp.Models
{
    public partial class Person
    {
        public Person()
        {
            Applications = new HashSet<Application>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PersonalId { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string AccountNum { get; set; } = null!;

        public virtual ICollection<Application> Applications { get; set; }
    }
}
