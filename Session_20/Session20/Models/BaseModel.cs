using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session20.Models
{
    public class BaseModel : IModel
    {
        public BaseModel()
        {
            this.ID = Guid.NewGuid();
        }


        public Guid ID { get; set; }

        public virtual string GetStringValue(string seperator)
        {
            return null;
        }

        public virtual BaseModel GetObjectFromString(string value, string seperator)
        {
            return null;
        }

        public virtual void CopyFrom(BaseModel SourceItem)
        { 
        
        }
    }
}
