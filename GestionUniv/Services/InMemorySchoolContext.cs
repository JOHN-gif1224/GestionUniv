using System;
using GestionUniv.Controllers;

namespace GestionUniv.Services;

public class InMemorySchoolContext
{
    private readonly List<StudentsController> _students = new();
    private readonly object _verrou = new();
}
    
