using System;

namespace Session20.Models
{
    public class Student : BaseModel
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string GetStringValue(string seperator)
        {
            var value = string.Format("{0}{5}{1}{5}{2}{5}{3}{5}{4}", ID, Name, Family, FatherName, DateOfBirth.ToShortDateString(), seperator);
            return value;
        }

        public override BaseModel GetObjectFromString(string value, string seperator)
        {
            var items = value.Split(new string[] { seperator }, StringSplitOptions.RemoveEmptyEntries);
            ID = new Guid(items[0]);
            Name = items[1];
            Family = items[2];
            FatherName = items[3];

            var dateParts = items[4].Split('/');// 12/25/1985  DD/MM/YYYY
            DateOfBirth = new DateTime(Convert.ToInt32(dateParts[2]), Convert.ToInt32(dateParts[0]), Convert.ToInt32(dateParts[1]));

            return this;
        }

        public override void CopyFrom(BaseModel SourceItem)
        {
            this.Name = ((Student)SourceItem).Name;
            this.Family = ((Student)SourceItem).Family;
            this.FatherName = ((Student)SourceItem).FatherName;
            this.DateOfBirth = ((Student)SourceItem).DateOfBirth;
        }
    }
}
