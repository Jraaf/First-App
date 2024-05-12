using First_App.Common.DTO;
using Fisrt_App.BLL.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.BLL.Services.Interfaces;

public interface IBoardService
{
    Task<List<BoardDTO>> GetAllAsync();
    Task<BoardDTO> GetByIdAsync(int id);
    Task<BoardDTO> CreateAsync(CreateBoardDTO DTO);
    Task<bool> DeleteAsync(int id);
    Task<BoardDTO> UpdateAsync(CreateBoardDTO DTO, int id);
}
