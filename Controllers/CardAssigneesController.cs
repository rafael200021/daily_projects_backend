using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers
{
    public class CardAssigneesController : DefaultController<CardAssignee>
    {
        public CardAssigneesController(IDefaultService<CardAssignee> service) : base(service)
        {
        }
    }
}
