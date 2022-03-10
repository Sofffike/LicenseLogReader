using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicenseLogReader.Models
{
    public class TsqlListViewModel
    {

        public string Inn { get; set; }
        public string OrgName { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string LogText { get; set; }

    }
}
