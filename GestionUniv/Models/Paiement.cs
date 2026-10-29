using System;
using System.ComponentModel.DataAnnotations;

namespace GestionUniv.Models;

public class Paiement
{
    [Key]
    public int IdPaiement {get; set;} 
    [Required]
    [Range(0,999999999999.999)]
    public float MontantInscription {get; set;}
    [Required]
    public string ModePaiement {get; set;} = "";
    [Required]
    public DateTime DatePaiement {get; set;} = DateTime.Now;
}
