using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers
{
    public class CardCommentController : DefaultController<CardComment>
    {
        public CardCommentController(IDefaultService<CardComment> service) : base(service)
        {
        }
    }
}
