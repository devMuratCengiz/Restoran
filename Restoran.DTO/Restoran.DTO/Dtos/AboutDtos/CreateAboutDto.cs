using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DTO.Dtos.AboutDtos
{
    public class CreateAboutDto
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string YearsOfExperience { get; set; }
        public string PopulerMasterChefs { get; set; }
    }
}
