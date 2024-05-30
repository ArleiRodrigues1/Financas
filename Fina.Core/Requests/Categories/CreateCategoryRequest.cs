using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "Título Inválido!")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 80 carácteres!")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Descrição Inválida!")]
    public string Description { get; set; }
}   