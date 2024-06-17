using System.ComponentModel.DataAnnotations;

namespace FinantialAdvice.Core.Requests.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "Título inválido :( ")]
    [MaxLength(ErrorMessage = "Máximo: 60 caracteres")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Descrição inválida")]
    public string Description { get; set; } = string.Empty;
}