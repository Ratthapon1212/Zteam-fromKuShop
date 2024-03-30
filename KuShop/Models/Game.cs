using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KuShop.Models;

public partial class Game
{
    [Key]
    [Required(ErrorMessage ="ต้องระบุรหัสสินค้า")]
    [Display(Name ="รหัสสินค้า")]
    public string GameId { get; set; } = null!;
    [Required(ErrorMessage ="ต้องระบุชื่อสินค้า")]
    [StringLength(100)]
    [Display(Name ="ชื่อสินค้า")]
    public string GameName { get; set; } = null!;
    [Display(Name ="ประเภท")]
    public byte? GenreId { get; set; }
    [Display(Name = "ยี่ห้อ")]
    public byte? DevId { get; set; }
    [Display(Name = "ราคา")]
    public double? GamePrice { get; set; }
    [Display(Name = "ต้นทุน")]
    public double? ShareCost { get; set; }
    [Display(Name = "Stockคงเหลือ")]
    public double? PdStk { get; set; }
    [Display(Name = "วันที่ขายล่าสุด")]
    public DateOnly? PdLastBuy { get; set; }
    [Display(Name = "วันที่ซื้อล่าสุด")]
    public DateOnly? PdLastSale { get; set; }

}
