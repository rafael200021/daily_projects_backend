using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers
{
    public class BoardTypeController : DefaultController<BoardType>
    {
        public BoardTypeController(IDefaultService<BoardType> service) : base(service)
        {
        }
    }
}
