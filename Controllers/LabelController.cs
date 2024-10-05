using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers
{
    public class LabelController : DefaultController<Label>
    {
        public LabelController(IDefaultService<Label> service) : base(service)
        {
        }
    }
}
