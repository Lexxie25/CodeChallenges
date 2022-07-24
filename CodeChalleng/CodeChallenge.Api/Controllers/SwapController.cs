using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace CodeChallenge.Api.Controllers
{
    [Route("api/cups/[controller]")]
    [ApiController]
    public class SwapController : ControllerBase
    {

        [HttpPost]
        public ActionResult<char> CupsSwap(string[] swaps)
        {
            //Regex finds pattern with endpoint and start point 
            Regex rg = new Regex(@"^[ABC][ABC]$");

            //position starts in B 
            int StartPos = 1;

            //go through possible senarios 
            foreach (string swap in swaps)
            {

                if (swap.Length != 2)
                    return BadRequest("Swap can only be 2 characters long");

                if (!swap.ToUpper().Contains(swap))
                    return BadRequest("Swap must contain Uppercase characters only");

                if (!rg.IsMatch(swap))
                    return BadRequest("Swap must contain ABC characters only");

                if (swap[0] == swap[1])
                    return BadRequest("Swap can not be in the same position");


                //Logic for ball moving start at positions matching A0 B1 C2

                if (swap.Contains("A") && StartPos == 0)
                {
                    StartPos = (swap.Contains("B")) ? 1 : 2;
                }
                else if (swap.Contains("B") && StartPos == 1)
                {
                    StartPos = (swap.Contains("A")) ? 0 : 2;
                }
                else if (swap.Contains("C") && StartPos == 2)
                {
                    StartPos = (swap.Contains("A")) ? 0 : 1;
                }
            }
            //Create string of letters to pull END position from 
            string Characters = "ABC";
            char EndPos = Characters[StartPos];

            return EndPos;
        }







    }
}
//Api endpoint is api/cups/swaps **

//swaps are 2 char long **
// Char is not uppercase **
//cup cant be swaped with its self 
// any other letter then ABC **

//Swap position logic  **
//return final position with approperate character **

