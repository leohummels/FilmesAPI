using System.ComponentModel.DataAnnotations;


namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="Campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(35, ErrorMessage = "Campo gênero deve conter no máximo 35 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Duração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
