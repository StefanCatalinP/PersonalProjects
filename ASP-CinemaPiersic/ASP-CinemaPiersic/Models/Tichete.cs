using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CinemaPiersic.Models
{
    public class Tichete

    {

        public int TicheteID { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public int FilmeID { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public int PromotiiTicheteID { get; set; }

        [System.ComponentModel.DataAnnotations.Range(1, 20)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Rand { get; set; }

        [System.ComponentModel.DataAnnotations.Range(1, 45)]
        [System.ComponentModel.DataAnnotations.Required]
        public int Loc { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Data")]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.Required]
        public DateTime Data { get; set; }

        public Filme Film { get; set; }
        public PromotiiTichete Nume { get; set; }


    }
}