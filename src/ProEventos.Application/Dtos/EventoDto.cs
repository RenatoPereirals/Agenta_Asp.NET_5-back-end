using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(50, MinimumLength = 3, 
        ErrorMessage = "O {0} Deve conter entro 3 e 50 caracteres.")]
        public string Tema { get; set; }

        [Display(Name = "Qtd pessoas")]
        [Range(1, 120000, ErrorMessage = "{0} não  pode ser maior que 120.000.")]
        public int QtdPessoas { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$",
                           ErrorMessage = "Não é uma imagem válida. (gif, jpg, jpeg, bmp ou png)")]
        public string ImagemURL { get; set; }

        [Required(ErrorMessage = "O campo {0} É obrigatório.")]
        [Phone(ErrorMessage = "O campo {0} precisa não pode conter letras.")]
        public string Telefone { get; set; }

        [Display(Name = "e-mail"),
        Required(ErrorMessage = "O campo {0} é obrigatório."),
        EmailAddress(ErrorMessage ="O campo {0} precisa ser um e-mail válido.")]
        public string Email { get; set; }
        public UserDto UserDto { get; set; }
        public int UserId { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> PalestrantesEventos { get; set; }
    }
}