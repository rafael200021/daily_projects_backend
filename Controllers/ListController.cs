using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers{

    public class ListController : DefaultController<List>
    {
        public ListController(IDefaultService<List> service) : base(service)
        {
        }
    }

}