using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Tickets
{
    [Key]
 
    public int TicketId {get; set;}
    [Required(ErrorMessage = "Este campo es nesesario")]
    public DateTime Fecha {get; set;}
    [Required(ErrorMessage = "Este campo es necesario")]
    public string? SolicitadoPor { get; set; }
    [Required(ErrorMessage = "Este campo es necesario")]
    public string? Asunto { get; set; }
    [Required(ErrorMessage = "Este campo es necesario")]
    public string? Descripcion { get; set; }

    [ForeignKey ("TicketId")]
    public List<TicketDetalle> TicketsDetalle 
    { get; set; } = new List<TicketDetalle>();
}