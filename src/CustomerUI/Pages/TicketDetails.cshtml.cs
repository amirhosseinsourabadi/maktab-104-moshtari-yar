using Data;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerUI.Pages
{
    public class TicketDetailsModel : PageModel
    {
        InMemoryDatabase dataBase = new InMemoryDatabase();

        #region Model
        [BindProperty]
        public Ticket CurrentTicket { get; set; }
        #endregion


        public IActionResult OnGet(int id)
        {
            var tickets = dataBase.GetTickets();
            var targetTicket = tickets.FirstOrDefault(t => t.Id == id);
            CurrentTicket = targetTicket;

            if (CurrentTicket == null)
                return NotFound();

            return Page();
        }
    }
}
