using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ReceivePDF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PdfController : ControllerBase
    {

        private readonly ILogger<PdfController> _logger;

        public PdfController(ILogger<PdfController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<string>> PostAsync()
        {
            string pdf;
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                pdf = await reader.ReadToEndAsync();
            }
              

            return "Good";
        }
    }
}
