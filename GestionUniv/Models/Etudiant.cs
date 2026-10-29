using System;
using System.ComponentModel.DataAnnotations;

namespace GestionUniv.Models;

public class Etudiant
{
    [Key]
    public int IdEtudiant { get; set; }
    // Champ obligatoire avec un message d'erreur personnalisé
    [Required(ErrorMessage ="Le Nom est obligatoire")]
    [MinLength(2, ErrorMessage ="Le Nom doit contenir au moins 2 caractères")]
    public string Nom { get; set; } = string.Empty;
    [Required(ErrorMessage ="Le Prénom est obligatoire")]
    [MinLength(2, ErrorMessage ="Le Prénom doit contenir au moins 2 caractères")]
    public string Prenom { get; set; } = string.Empty;
    [Required(ErrorMessage ="L'email est obligatoire")]

    public string Email { get; set; } = string.Empty;
}
