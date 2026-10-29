using System;

namespace GestionUniv.Models;

public class Cours
{
    public int IdCours { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Credits { get; set; }
}
