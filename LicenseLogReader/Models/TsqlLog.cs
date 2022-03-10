using System;
using System.Collections.Generic;

#nullable disable

namespace LicenseLogReader.Models
{
    public partial class TsqlLog
    {
        public int IdLog { get; set; }
        public DateTime? ChangeTime { get; set; }
        public string Inn { get; set; }
        public string LogText { get; set; }
    }
}
