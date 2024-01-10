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


    //  Soma de dois Numeros:

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Sum(string firstNumber, string secondNumber)
    {
        if(IsNumerc(firstNumber) && IsNumerc(secondNumber))
        {
            var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }
        return BadRequest("Invalid Input");
    }

    //  Subtração de dois Numeros:

    [HttpGet("sub/{firstNumber}/{secondNumber}")]
    public IActionResult Sub(string firstNumber, string secondNumber)
    {
        if (IsNumerc(firstNumber) && IsNumerc(secondNumber))
        {
            var sum = (ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber));

            return Ok(sum.ToString());
        }

        return BadRequest("Invalid Input");
    }



    //  Multiplicação de dois Numeros:

    [HttpGet("mult/{firstNumber}/{secondNumber}")]
    public IActionResult Mult(string firstNumber, string secondNumber)
    {
        if (IsNumerc(firstNumber) && IsNumerc(secondNumber))
        {
            var sum = (ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber));

            return Ok(sum.ToString());
        }

        return BadRequest("Invalid Input");
    }


    //  Media de tres Numeros:

    [HttpGet("media/{firstNumber}/{secondNumber}/{thirdNumber}")]
    public IActionResult Media(string firstNumber, string secondNumber, string thirdNumber)
    {
        if (IsNumerc(firstNumber) && IsNumerc(secondNumber) && IsNumerc(thirdNumber))
        {
            var sum = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber) + ConvertToDecimal(thirdNumber)) / 3;

            return Ok(sum.ToString());
        }

        return BadRequest("Invalid Input");
    }










    private decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;

        if(decimal.TryParse(strNumber, out decimalValue))
        {
            return decimalValue;
        }

        return 0;
    }

    private bool IsNumerc(string strNumber)
    {
        double number;
        bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        return isNumber;
    }
}

