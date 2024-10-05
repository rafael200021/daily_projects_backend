using Daily_Project.IServices;
using Daily_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Daily_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardMemberController:DefaultController<BoardMember>
    {

          public BoardMemberController(IDefaultService<BoardMember> service): base(service) { }

    }
}
