using System;
using Architecture_lab.Repositories.Base;

namespace Architecture_lab.Repositories.Member.Entity
{
    public class MemberDataModel : DataModelBase
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}