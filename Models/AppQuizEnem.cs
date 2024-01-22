using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizUpEnem.Models
{
    public class AppQuizEnem
    {
        public int Id { get; set; }

        [DisplayName("Materia")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Materia { get; set; }
        //[DisplayName("Exercicios Criado em: ")]
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime LastUpdateFinished { get; set; } = DateTime.Now;
        public string User {get; set;}
    }
}