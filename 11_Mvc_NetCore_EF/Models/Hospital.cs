﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _11_Mvc_NetCore_EF.Models
{

    [Table("HOSPITAL")]

    public class Hospital
    {
        [Key]
        [Column("HOSPITAL_COD")]
        public int HospitalCod { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DIRECCION")]
        public string Direccion { get; set; }

        [Column("TELEFONO")]
        public string Telefono { get; set; }

        [Column("NUM_CAMA")]
        public int NumCama { get; set; }
    }
}
