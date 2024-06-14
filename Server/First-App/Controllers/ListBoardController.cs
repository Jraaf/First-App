using First_App.Common.DTO;
using Fisrt_App.BLL.Exceptions;
using Fisrt_App.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace First_App.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableCors("AllowAll")]
public class ListBoardController : ControllerBase
{
    private readonly IListBoardService _service;
    public ListBoardController(IListBoardService service)
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
    [HttpGet("/board={boardId}")]
    public async Task<IActionResult> GetManyByBoardId(int boardId)
    {
        try
        {
            var data = await _service.GetManyByBoardId(boardId);
            return Ok(data);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }
    [HttpPost]
    public async Task<IActionResult> Post(CreateListBoardDTO obj)
    {
        try
        {
            return Ok(await _service.CreateAsync(obj));
        }
        catch(Exception e)
        {
            return BadRequest(e.Message);
        }
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
    [HttpPatch]
    public async Task<IActionResult> Update(CreateListBoardDTO obj, int id)
    {
        try
        {
            return Ok(await _service.UpdateAsync(obj, id));

        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}
