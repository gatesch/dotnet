using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using Microsoft.Extensions.Configuration;


namespace MPTDevOpsWebCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        private readonly IConfiguration _config;
        public void OnGet()
        {
            // Pass read configurations to web page.
            ViewData["AppEnv"] = _config.GetValue<string>("AppSettings:AppENV");
            ViewData["DBName"] = _config.GetValue<string>("AppSettings:AppDBNAME");
            ViewData["MyTNS"] = _config.GetValue<string>("AppSettings:MyTNS");
            ViewData["ConStr"] = _config.GetValue<string>("ConnectionString");
            ViewData["ExtraSetting"] = _config.GetValue<string>("ExtraSettingNotInSettingsFile");
            ViewData["CICDRef"] = _config.GetValue<string>("CICDRef");
            ViewData["DeployTemplateFilename"] = _config.GetValue<string>("DeployTemplateFilename");
        }
    }
}
