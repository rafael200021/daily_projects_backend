using Daily_Project.IServices;
using Daily_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Daily_Project.Controllers
{
    public class CardAttachmentController : DefaultController<CardAttachment>
    {
        public CardAttachmentController(IDefaultService<CardAttachment> service) : base(service)
        {
        }

        [HttpGet("Upload/{fileName}")]
        public async Task<IActionResult> DownloadArquivo(string fileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Media/Card", fileName);

            if (!System.IO.File.Exists(path))
                return NotFound();

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;

            return File(memory, "application/octet-stream", fileName);
        }


        [HttpPost("Upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {

            if (file == null)
                return BadRequest("Arquivo não encontrado");

            long timeStamp = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();

            var fileName = file.FileName.Split(".")[0] + timeStamp + "." + file.FileName.Split(".")[1];

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Media/Card", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new { FileName = fileName });
        }

    }
}
