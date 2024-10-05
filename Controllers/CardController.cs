using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers
{
    public class CardController : DefaultController<Card>
    {
        public CardController(IDefaultService<Card> service) : base(service)
        {
        }
    }
}
