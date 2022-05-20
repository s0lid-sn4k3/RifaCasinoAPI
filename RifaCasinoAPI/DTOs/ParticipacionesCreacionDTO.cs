﻿using RifaCasinoAPI.Entidades;
using System.ComponentModel.DataAnnotations;

namespace RifaCasinoAPI.DTOs
{
    public class ParticipacionesCreacionDTO
    {
        [Required]
        public int idParticipante { get; set; }

        [Required]
        public int idRifa { get; set; }
        public int noLoteria { get; set; }
    }
}
