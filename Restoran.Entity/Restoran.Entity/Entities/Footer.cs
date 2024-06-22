using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.Entity.Entities
{
    public class Footer
    {
        public int Id { get; set; }
        public string Address  { get; set; }
        public string Phone  { get; set; }
        public string Mail  { get; set; }
        public string OpeningDaysInWeek  { get; set; }
        public string OpeningHoursInWeek  { get; set; }
        public string OpeningDaysWeekEnd { get; set; }
        public string OpeningHoursWeekEnd { get; set; }
    }
}
