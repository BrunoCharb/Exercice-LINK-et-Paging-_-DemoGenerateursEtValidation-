﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoGenerateursEtValidation.Models
{
    public class Auto
    {
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }

        [Required]
        public string Marque { get; set; }

        [Display (Name = "Modèle")] //Modifier l'affichage des label
        [Required]
        public string Model { get; set; }

        [Required (ErrorMessage = "Le prix est obligatoire")] //Validation avec messages d'erreurs
        [Range (0, 200000, ErrorMessage = "Le pris doit être entre 0 et 200 000$")]
        [DisplayFormat(DataFormatString = "{0:C2}")] //Choisir le format d'affichage
        public double? Prix { get; set; }

        public Auto() { }

        public Auto(int id, string marque, string model, double prix)
        {
            Id = id;
            Marque = marque;
            Model = model;
            Prix = prix;
        }   
    }
}
