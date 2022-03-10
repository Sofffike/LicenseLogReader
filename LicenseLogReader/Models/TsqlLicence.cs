using System;
using System.Collections.Generic;

#nullable disable

namespace LicenseLogReader.Models
{
    public partial class TsqlLicence
    {
        public int IdLicence { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public string OrgName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public DateTime? Deadline { get; set; }
        public int? WorkCnt { get; set; }
        public string Roles { get; set; }
        public string Sql { get; set; }
        public string Sent { get; set; }
        public string RequestEmail { get; set; }
        public int? RequestWorkCnt { get; set; }
        public string RequestRoles { get; set; }
        public string RequestFile { get; set; }
        public string Type { get; set; }
    }
}
