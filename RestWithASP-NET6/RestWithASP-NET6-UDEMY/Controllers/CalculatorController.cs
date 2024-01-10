using Microsoft.AspNetCore.Mvc;

namespace RestWithASP_NET6_UDEMY.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
   

    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Get(string firstNumber, string secondNumber)
    {
        if(IsNumerc(firstNumber) && IsNumerc(secondNumber))
        {
            var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    private int ConvertToDecimal(string secondNumber)
    {
        throw new NotImplementedException();
    }

    private bool IsNumerc(string firstNumber)
    {
        throw new NotImplementedException();
    }
}

