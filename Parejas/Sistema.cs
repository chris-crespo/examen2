using System.Collections.Generic;
using Parejas;

namespace Parejas;

public class Sistema
{
    public List<Persona> Personas { get; } = new()
    {
        new Persona("A", Sexo.H, 20),
        new Persona("B", Sexo.M, 30),
        new Persona("C", Sexo.M, 10),
        new Persona("D", Sexo.H, 50),
        new Persona("E", Sexo.M, 35),
        new Persona("F", Sexo.H, 96),
        new Persona("G", Sexo.H, 22),
        new Persona("H", Sexo.H, 39),
        new Persona("I", Sexo.M, 43),
        new Persona("J", Sexo.M, 17)
    };

    public bool AdmitenDescendencia(Persona a, Persona b) 
        => a.Sexo != b.Sexo 
        && Math.Abs(a.Edad - b.Edad) <= 12 
        && Math.Abs(a.RangoDeEdad - b.RangoDeEdad) <= 1;

    public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        => personas
            .SelectMany((p1, i) => personas
                .GetRange(i + 1, personas.Count() - i - 1)
                .Select(p2 => (p1, p2))
                .Where(t => AdmitenDescendencia(t.p1, t.p2)))
            .ToList();


    public string Saludo(string nombre) => $"Saludos {nombre}!";


}
