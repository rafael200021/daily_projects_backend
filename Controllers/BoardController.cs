using Daily_Project.IServices;
using Daily_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Daily_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : DefaultController<Board>
    {

        
        public BoardController(IDefaultService<Board> service) : base(service)
        {
        }
    }
}
