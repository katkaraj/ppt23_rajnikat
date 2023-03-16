
namespace Ppt23.Client.ViewModels
{
    public class VybaveniVm
    {
        public string Name { get; set; }
        public DateTime BoughtDateTime { get; set; }
        public DateTime LastRevisionDateTime { get; set; }
        public bool IsRevisionNeeded { get; set; }
        public bool IsInEditMode { get; set; }

        public VybaveniVm()
        {
            this.Name = RandomString(10);
            this.BoughtDateTime = RandomDateTime();
            this.LastRevisionDateTime = RevisionRandomDateTime(BoughtDateTime, DateTime.Today);
            this.IsRevisionNeeded = MakeRevision();
            this.IsInEditMode = false;
        }

        private static Random rnd = new Random();
        public static string RandomString(int lenght)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, lenght).Select(s => s[rnd.Next(s.Length)]).ToArray());
        }

        public static DateTime RandomDateTime()
        {
            DateTime start = new DateTime(2018, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        public static DateTime RevisionRandomDateTime(DateTime from, DateTime to)
        {
            DateTime start = from;
            int range = (to - from).Days;
            return start.AddDays(rnd.Next(range));
        }

        public bool MakeRevision()
        {
            if(((DateTime.Today - LastRevisionDateTime).TotalDays) > 365)
            {
                 return true;
            }
            else
            {
                return false;
            }
        }


    }
}
