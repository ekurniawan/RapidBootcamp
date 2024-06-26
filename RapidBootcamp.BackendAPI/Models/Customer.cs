﻿using System.ComponentModel.DataAnnotations;

namespace RapidBootcamp.BackendAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public IEnumerable<Wallet>? Wallets { get; set; }
    }
}
