using System.ComponentModel.DataAnnotations;

namespace HealthCenterMaster.Models;
public class Schedule
{
    [Key]
    [Display(Name = "Id")]
    public int Id { get; set; }

    [Display(Name = "Data do Agendamento")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime Date { get; set; }

    [Display(Name = "Hora do Agendamento")]
    [DataType(DataType.Time)]
    [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
    public DateTime Time { get; set; }

    [Display(Name = "Cliente")]
    public int ClientId { get; set; }
    public Client? Client { get; set; }

    [Display(Name = "Fisioterapeuta")]
    public int PhysiotherapistId { get; set; }
    public Physiotherapist? Physiotherapist { get; set; }
}