using Microsoft.AspNetCore.Mvc;
using Mscc.GenerativeAI;
using AIProject.Models;

namespace AIProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeminiController : ControllerBase
    {
        private readonly GoogleAI _googleAI;

        public GeminiController(GoogleAI googleAI)
        {
            _googleAI = googleAI;
        }

        [HttpPost("prompt")]
        public async Task<IActionResult> Prompt([FromBody] PromptRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Text))
                return BadRequest("Prompt text is required.");

            try
            {
                // CHANGE THIS LINE: Specify the Flash model
                var model = _googleAI.GenerativeModel(model: Model.Gemini15Flash); 
                // Or for the older, but still good 'gemini-pro' (not 1.5):
                // var model = _googleAI.GenerativeModel(model: Model.GeminiPro);

                var result = await model.GenerateContent(request.Text);

                return Ok(new
                {
                    Prompt = request.Text,
                    Response = result.Text
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GeminiController.Prompt: {ex.Message}");
                return StatusCode(500, $"Error generating content: {ex.Message}");
            }
        }
    }
}