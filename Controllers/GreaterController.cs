//Elizar Garcia
//10-25-22
//MiniCh#4GreaterthanorLessthanEndpoint.
// the user will unput two number on postman and get the results if its greater than less than or equal to.
//Peer Review: John Magpantay     notes : Added If else statement that I didn't even know we could add, Peer reviewing his work gave me some kind of light on how to move forward, Code is clean, Goodjob overall!

using Microsoft.AspNetCore.Mvc;

namespace GarciaEGreaterthanorLessthanEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterController : ControllerBase
{
    [HttpGet]
    [Route("greater/{number1}/{number2}")]

    public string math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);

        if(convertNum1 > convertNum2)
        {
            return $"{number1} is greater than {number2}. ";

        }else if(convertNum1 < convertNum2)
        {
            return $"{number1} is less than {number2}.";

        }else
        {
            return $"{number1} is equal to {number2}.";

        }

    }
    
}