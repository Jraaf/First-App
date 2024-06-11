using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.BLL.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException() : base() { }
    public NotFoundException(string message)
        : base(message) { }
    public NotFoundException(int id)
        : base($"There is no object with id {id}") { }
}
