using System.ComponentModel.DataAnnotations;

namespace TeamManager.UI.Models
{
    public enum AttendanceStatus
    {
        [Display(Name = "Presente")]
        Present,              // Llegó y participó

        [Display(Name = "Presente sin práctica")]
        PresentNoPractice,

        [Display(Name = "Ausente")]
        AbsentUnjustified,

        [Display(Name = "Ausente por lesión")]
        AbsentInjury,

        [Display(Name = "Ausente por trabajo")]
        AbsentWork,

        [Display(Name = "Ausencia personal")]
        AbsentPersonal
    }
}
