using System;

namespace GestionUniv.Models;

public class Grade
{
    public int Id { get; set; }

    
    public double Value { get; set; }

    public Cours Course { get; set; } = new();
}
