using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.Annotations
{
    public class EdicaoAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value.ToString().StartsWith("MTG");
        }
    }
}