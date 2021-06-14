using System;

namespace Session20.Models
{
    public interface IModel
    {
        Guid ID { get; set; }

        string GetStringValue(string seperator);
    }
}
