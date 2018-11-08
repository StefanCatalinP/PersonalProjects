using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CinemaPiersic.Models
{
    public enum Rating
    {
        AG, AP12, N15, IM18, IC
    }

    public class Filme

    {

        public int FilmeID { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(60, MinimumLength = 3)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Film { get; set; }

        [System.ComponentModel.DataAnnotations.StringLength(60, MinimumLength = 3)]
        [System.ComponentModel.DataAnnotations.Required]
        public string Regizor { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public Rating? Rating { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Ora { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Data premiera")]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.Required]
        public DateTime Data_Premiera { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Data final")]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [System.ComponentModel.DataAnnotations.Required]
        public DateTime Data_Finala { get; set; }




    }


}