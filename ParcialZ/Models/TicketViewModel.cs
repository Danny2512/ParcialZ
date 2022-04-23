using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace ParcialZ.Models
{
    public class TicketViewModel : EditTicketViewModel
    {
        public int EntranceId { get; set; }

        public IEnumerable<SelectListItem> Entrances { get; set; }

    }
}
