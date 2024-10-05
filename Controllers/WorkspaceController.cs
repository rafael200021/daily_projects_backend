using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Controllers
{
    public class WorkspaceController:DefaultController<Workspace>
    {

         public WorkspaceController(IDefaultService<Workspace> service):base(service) { }

    }
}
