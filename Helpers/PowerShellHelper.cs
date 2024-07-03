using System.Management.Automation;

namespace DoThePowerShell.Helpers
{
    public class PowerShellHelper
    {
        public string ExecutePowerShellScript(string scriptPath)
        {
            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddCommand(scriptPath);
                var results = powerShell.Invoke();

                if (powerShell.HadErrors)
                {
                    return "Error executing script.";
                }

                // Combine the results into a single string
                string output = string.Join("\n", results);
                return output;
            }
        }
    }
}
