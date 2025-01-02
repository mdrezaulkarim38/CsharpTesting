using System.ComponentModel.DataAnnotations;
namespace api.Dtos.Stock;
public class UpdateStockRequestDto
{
    [Required]
    [MaxLength(10, ErrorMessage = "Symbol  cannot be over 10 characters")]
    public string? Symbol { get; set; }
    [Required]
    [MaxLength(10, ErrorMessage = "Company Name  cannot be over 10 characters")]
    public string? CompanyName { get; set; }
    [Required]
    [Range(1,1000000000)]
    public decimal Purchase { get; set; }
    [Required]
    [Range(0.001,100)]
    public decimal LastDiv { get; set; }
    [Required]
    [MaxLength(10, ErrorMessage = "Industry can not be over 10 characters")]
    public string? Industry { get; set; }
    [Range(1, 5000000000)]
    public long MarketCap { get; set; }
}