using Microsoft.AspNetCore.Mvc;
using DoThePowerShell.Helpers;

namespace DoThePowerShell.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PowerShellController : ControllerBase
    {   
        // constructor that makes an instance of the powershell helper
        private readonly PowerShellHelper _powerShellHelper;
        public PowerShellController()
        {
            var powerShellHelper = new PowerShellHelper();
            _powerShellHelper = powerShellHelper;
        }  
        
                
        [HttpGet("RunDoAthing")]
        [HttpPost("RunDoAthing")]
        public IActionResult RunDoAthing()
        {
            string scriptPath = "Scripts/DoAThing.ps1";
            string result = _powerShellHelper.ExecutePowerShellScript(scriptPath);
            return Ok(new { Output = result });
        }

        [HttpGet("RunDoAnotherThing")]
        public IActionResult RunDoAnotherThing()
        {
            string scriptPath = "Scripts/DoAnotherThing.ps1";
            string result = _powerShellHelper.ExecutePowerShellScript(scriptPath);
            return Ok(new { Output = result });
        }
    }
}
