using System.ComponentModel.DataAnnotations;

namespace CrmTechTitans.Models
{
    public enum MembershipType
    {
        Basic,
        Premium,
        Enterprise,
        Partner,
        Associate,
        [Display(Name = "Government & Education")]
        GovernmentEducation,
        [Display(Name = "Non Profit")]
        NonProfit
    }
}
