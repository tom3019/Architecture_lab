using System;

namespace Architecture_lab.Repositories.Base
{
    public abstract class DataModelBase
    {
        public string Id { get; set; }
        public DateTime CreateTime { get; set; }
    }
}