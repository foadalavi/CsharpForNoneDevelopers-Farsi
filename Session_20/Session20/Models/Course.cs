using System;

namespace Session20.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public int Point { get; set; }

        public override string GetStringValue(string seperator)
        {
            var value = string.Format("{0}{3}{1}{3}{2}", ID, Name, Point, seperator);
            return value;
        }

        public override BaseModel GetObjectFromString(string value, string seperator)
        {
            var items = value.Split(new string[] { seperator }, StringSplitOptions.RemoveEmptyEntries);
            ID = new Guid(items[0]);
            Name = items[1];
            Point = Convert.ToInt32(items[2]);

            return this;
        }

        public override void CopyFrom(BaseModel SourceItem)
        {
            this.Name = ((Course)SourceItem).Name;
            this.Point = ((Course)SourceItem).Point;
        }
    }
}
