﻿using Core.Dto;
using Core.Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervationSystem.Dto.Concrete
{
    public class CardWriteDto : IReadDto
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public User Customer { get; set; }
        public int CardNumber { get; set; }
        public int CardPassword { get; set; }
        public int Balance { get; set; }
    }
}