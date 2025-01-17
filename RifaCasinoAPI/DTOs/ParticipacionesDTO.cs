﻿using RifaCasinoAPI.Entidades;
using System.ComponentModel.DataAnnotations;

namespace RifaCasinoAPI.DTOs
{
    public class ParticipacionesDTO
    {
        public int id { get; set; }
        [Required]
        public string idParticipante { get; set; }
        public Participantes participante { get; set; }
        [Required]
        public int idRifa { get; set; }
        public int noLoteria { get; set; }

    }
}
