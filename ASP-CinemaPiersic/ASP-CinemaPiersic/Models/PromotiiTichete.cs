using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CinemaPiersic.Models
{

    public class PromotiiTichete
    {

        public int PromotiiTicheteID { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(60, MinimumLength = 3)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Nume { get; set; }

        [System.ComponentModel.DataAnnotations.Range(10, 25)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Pret { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(120, MinimumLength = 3)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Descriere { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Inceput promotie")]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.Required]
        public DateTime Data_Incepere { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Sfarsit promotie")]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.Required]
        public DateTime Data_Sfarsit { get; set; }

    }
}
