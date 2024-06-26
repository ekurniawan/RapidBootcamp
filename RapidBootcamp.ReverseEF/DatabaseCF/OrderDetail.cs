﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RapidBootcamp.ReverseEF.DatabaseCF;

[Index("OrderHeaderId", Name = "IX_OrderDetails_OrderHeaderId")]
[Index("ProductId", Name = "IX_OrderDetails_ProductId")]
public partial class OrderDetail
{
    [Key]
    public int OrderDetailId { get; set; }

    [Required]
    public string OrderHeaderId { get; set; }

    public int ProductId { get; set; }

    public int Qty { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [ForeignKey("OrderHeaderId")]
    [InverseProperty("OrderDetails")]
    public virtual OrderHeader OrderHeader { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("OrderDetails")]
    public virtual Product Product { get; set; }
}