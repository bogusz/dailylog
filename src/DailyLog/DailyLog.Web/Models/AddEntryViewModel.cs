using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DailyLog.Web.Models
{
    public class AddEntryViewModel
    {
        [Display(Name = "Treść")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}