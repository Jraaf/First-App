using AutoMapper;
using First_App.Common.DTO;
using Fisrt_App.BLL.Exceptions;
using Fisrt_App.DAL.Repository.Repo;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisrt_App.BLL.Services.Base;

public class Service<TDTO, CreateTDTO, T> : IService<TDTO, CreateTDTO> 
    where TDTO : class
    where CreateTDTO : class
    where T: class
{
    private readonly IMapper _mapper;
    private readonly IRepo<T,int> _repo;
    public Service(IMapper mapper,IRepo<T,int> repo)
    {
        _mapper = mapper;        
        _repo = repo;
    }

    public async Task<TDTO> CreateAsync(CreateTDTO DTO)
    {
        var data = _mapper.Map<T>(DTO);
        return _mapper.Map<TDTO>(await _repo.AddAsync(data));
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id);
        if (data != null)
        {
            return await _repo.DeleteAsync(data);
        }
        throw new NotFoundException(id);
    }

    public async Task<List<TDTO>> GetAllAsync()
    {
        var data = await _repo.GetAllAsync();
        return _mapper.Map<List<TDTO>>(data);
    }

    public async Task<TDTO> GetByIdAsync(int id)
    {
        var data = await _repo.GetAsync(id);
        return _mapper.Map<TDTO>(data);
    }

    public async Task<TDTO> UpdateAsync(CreateTDTO DTO, int Id)
    {
        var data = await _repo.GetAsync(Id)
                ?? throw new NotFoundException(Id);

        var card = _mapper.Map(DTO, data);

        return _mapper.Map<TDTO>(await _repo.UpdateAsync(card));

    }
}
