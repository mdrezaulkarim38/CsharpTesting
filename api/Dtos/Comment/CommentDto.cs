namespace api.Dtos.Comment;

public class CommentDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedOn { get; set; }
    public int? StockId { get; set; }
}