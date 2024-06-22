namespace Restoran.WebUI.DTOs.ReservationDtos
{
    public class CreateReservationDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
        public int NoOfPeople { get; set; }
        public string SpecialRequest { get; set; }
    }
}
