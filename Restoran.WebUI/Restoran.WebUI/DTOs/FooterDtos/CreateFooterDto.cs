namespace Restoran.WebUI.DTOs.FooterDtos
{
    public class CreateFooterDto
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string OpeningDaysInWeek { get; set; }
        public string OpeningHoursInWeek { get; set; }
        public string OpeningDaysWeekEnd { get; set; }
        public string OpeningHoursWeekEnd { get; set; }
    }
}
