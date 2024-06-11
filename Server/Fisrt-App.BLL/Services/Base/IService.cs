using First_App.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.BLL.Services.Base;

public interface IService<TDTO, CreateTDTO>
    where TDTO : class
    where CreateTDTO : class
{
    Task<List<TDTO>> GetAllAsync();
    Task<TDTO> GetByIdAsync(int id);
    Task<TDTO> CreateAsync(CreateTDTO DTO);
    Task<bool> DeleteAsync(int id);
    Task<TDTO> UpdateAsync(CreateTDTO DTO, int Id);
}
