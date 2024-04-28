using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App.Common.DTO;

public class CreateCardDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateOnly Deadline { get; set; }
}
