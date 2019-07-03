using BookAndEat.DataModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookAndEat.DataModels
{
    public enum Mesurement
    {
        [Display(Name = "л")]
        Liter,
        [Display(Name = "кг")]
        Kilogram,
        [Display(Name = "г")]
        Gram,
        [Display(Name = "шт.")]
        Piece
    }
}
