using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DTO.Dtos.ReservationDtos
{
    public class UpdateReservationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
        public int NoOfPeople { get; set; }
        public string SpecialRequest { get; set; }
    }
}
