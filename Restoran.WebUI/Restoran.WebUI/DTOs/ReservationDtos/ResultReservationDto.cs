namespace Restoran.WebUI.DTOs.ReservationDtos
{
    public class ResultReservationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
        public int NoOfPeople { get; set; }
        public string SpecialRequest { get; set; }
    }
}
