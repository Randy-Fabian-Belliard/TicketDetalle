using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TicketDetalle
{
    [Key]
    public int TicketDetalleId { get; set; }

    [ForeignKey ("TicketId")]
    public int TicketId {get; set;}

    [Required(ErrorMessage = "Este campo es necesario")]
    public string? Emisor{ get; set; }

    [Required(ErrorMessage = "Este campo es requerido")]
    public string? Mensaje { get; set; }
}