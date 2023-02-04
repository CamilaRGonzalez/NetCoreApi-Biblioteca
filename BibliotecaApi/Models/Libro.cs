using System;
using System.Collections.Generic;

namespace BibliotecaApi.Models;

public partial class Libro
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Autor { get; set; }

    public string? Editorial { get; set; }

    public int? EjemplaresDisponibles { get; set; }
}
