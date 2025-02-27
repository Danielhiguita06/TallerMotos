﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerMotos.DAL.Entities
{
    public class Buy : AuditBase
    {
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; } // Código único, generado automáticamente

        [Display(Name = "Fecha de compra")]
        [Required]
        public DateTime PurchaseDate { get; set; } = DateTime.Now; // Fecha asignada automáticamente

        // Relación con Client
        public int ClientId { get; set; } // Clave foránea
        public virtual Client Client { get; set; } // Propiedad de navegación

        // Relación con Product
        public Guid ProductId { get; set; } // Clave foránea
        public virtual Product Product { get; set; } // Propiedad de navegación
    }
}
