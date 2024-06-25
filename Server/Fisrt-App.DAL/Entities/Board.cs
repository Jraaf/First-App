namespace Fisrt_App.DAL.Entities;

public class Board
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<ListBoard>? ListBoards { get; set; }
}
