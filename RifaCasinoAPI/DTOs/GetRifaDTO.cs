﻿using RifaCasinoAPI.Entidades;
using System.ComponentModel.DataAnnotations;

namespace RifaCasinoAPI.DTOs
{
    public class GetRifaDTO
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool vigente { get; set; }
        public List<GetParticipacionesDTO> participaciones { get; set; }
        public List<GetPremioDTO> premioList { get; set; }
    }
}
