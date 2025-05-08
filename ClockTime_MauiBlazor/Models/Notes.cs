using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTime_MauiBlazor.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contend { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate {  get; set; } = DateTime.UtcNow;


        [NotMapped]
        public int Top_Aux {  get; set; } 

    }
}
