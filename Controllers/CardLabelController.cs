using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers
{
    public class CardLabelController : DefaultController<CardLabel>
    {
        public CardLabelController(IDefaultService<CardLabel> service) : base(service)
        {
        }
    }
}
