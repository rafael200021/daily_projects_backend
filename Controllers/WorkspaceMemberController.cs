using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers
{
    public class WorkspaceMemberController : DefaultController<WorkspaceMember>
    {
        public WorkspaceMemberController(IDefaultService<WorkspaceMember> service) : base(service)
        {
        }
    }
}
