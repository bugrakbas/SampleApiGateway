﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOs.Request
{
    public class OrderRequest
    {
        [Required]
        public Guid OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int AddressId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
