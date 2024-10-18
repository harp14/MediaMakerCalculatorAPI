using Microsoft.AspNetCore.Mvc;
using MediaMaker_Calculator_API.Services;

namespace MediaMaker_Calculator_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] CalculationRequest request)
        {
            var result = _calculatorService.Add(request.FirstNumber, request.SecondNumber);
            return Ok(new { result } );
        }

        [HttpPost("subtract")]
        public IActionResult Subtract([FromBody] CalculationRequest request)
        {
            var result = _calculatorService.Subtract(request.FirstNumber, request.SecondNumber);
            return Ok(new { result });
        }

        [HttpPost("multiply")]
        public IActionResult Multiply([FromBody] CalculationRequest request)
        {
            var result = _calculatorService.Multiply(request.FirstNumber, request.SecondNumber);
            return Ok(new { result });
        }

        [HttpPost("divide")]
        public IActionResult Divide([FromBody] CalculationRequest request)
        {
            try
            {
                var result = _calculatorService.Divide(request.FirstNumber, request.SecondNumber);
                return Ok(new { result });
            }
            catch (Exception ex) // Added exception handling here especially for handling divided by zero exception.
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
