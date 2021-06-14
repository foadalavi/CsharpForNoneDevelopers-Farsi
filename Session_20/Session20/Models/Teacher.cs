using System;

namespace Session20.Models
{
    public class Teacher : BaseModel
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public override string GetStringValue(string seperator)
        {
            var value = string.Format("{0}{3}{1}{3}{2}", this.ID, this.Name, this.Family, seperator);
            return value;
        }

        public override BaseModel GetObjectFromString(string value, string seperator)
        {
            var items = value.Split(new string[] { seperator }, StringSplitOptions.RemoveEmptyEntries);
            ID = new Guid(items[0]);
            Name = items[1];
            Family = items[2];

            return this;
        }

        public override string ToString()
        {
            return $"Full Name: {this.Name} {this.Family}, ID: {this.ID}.";
        }

        public override void CopyFrom(BaseModel SourceItem)
        {
            this.Name = ((Teacher)SourceItem).Name;
            this.Family = ((Teacher)SourceItem).Family;
        }
    }
}
