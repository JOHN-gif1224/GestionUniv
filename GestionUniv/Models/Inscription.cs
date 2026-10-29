using System;
using System.ComponentModel.DataAnnotations;

namespace GestionUniv.Models;

public class Inscription
{
    [Key]
    public int IdInscription { get; set; }
    public int IdEtudiant { get; set; }
    [Required(ErrorMessage = "La date est obligatoire")]
    public DateTime DateInscription { get; set; } = DateTime.Now;
    [Required(ErrorMessage = "Le statut est obligatoire")]
    public string Statut { get; set; } = "En cours";
    // 
    public Etudiant? Etudiant { get; set; }
}
