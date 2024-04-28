using First_App.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.BLL.Services.Interfaces;

public interface ICardService
{
    Task<List<CardDTO>> GetAllAsync();
    Task<CardDTO> GetByIdAsync(int id);
    Task<bool> CreateAsync(CreateCardDTO cardDTO);
    Task<bool> DeleteAsync(int id);
    Task<bool> UpdateAsync(CreateCardDTO cardDTO, int Id);
}
