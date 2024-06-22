using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DTO.Dtos.MenuDtos
{
    public class CreateMenuDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
