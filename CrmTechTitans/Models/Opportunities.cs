using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class Opportunities
    {
        public int ID { get; set; }


        [StringLength(200, ErrorMessage = "Opportunity name can't be longer than 200 characters")]
        public string Opportunity { get; set; }
    }
}
