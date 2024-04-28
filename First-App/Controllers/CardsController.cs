using First_App.Common.DTO;
using Fisrt_App.BLL.Exceptions;
using Fisrt_App.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_App.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CardsController : ControllerBase
{
    private readonly ICardService _service;
    public CardsController(ICardService service)
    {
        _service = service;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            return Ok(await _service.GetByIdAsync(id));

        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
    [HttpGet]
    public async Task<List<CardDTO>> GetAll()
    {
        return await _service.GetAllAsync();
    }
    [HttpPost]
    public async Task<bool> Post(CreateCardDTO obj)
    {
        return await _service.CreateAsync(obj);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            return Ok(await _service.DeleteAsync(id));
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
    [HttpPut]
    public async Task<bool> Update(CreateCardDTO obj, int id)
    {
        return await _service.UpdateAsync(obj, id);
    }
}
