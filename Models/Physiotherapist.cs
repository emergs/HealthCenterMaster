using System.ComponentModel.DataAnnotations;

namespace HealthCenterMaster.Models;

public class Physiotherapist
{
    [Key]
    [Display(Name = "Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do fisioterapeuta é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CREFITO do fisioterapeuta é obrigatório.")]
    [StringLength(10, ErrorMessage = "O CREFITO não pode ter mais de 10 caracteres.")]
    public string Crefito { get; set; } = string.Empty;

    // Propriedade para o e-mail do fisioterapeuta
    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "O e-mail fornecido não é válido.")]
    public string Email { get; set; } = string.Empty;
}