namespace Parejas;

public enum Sexo { H, M };

public enum RangoDeEdad 
{
    MuyJoven,
    Joven,
    Plenitud,
    Madurez,
    Vejez
};

public class Persona 
{
    public string Nombre { get; }
    public Sexo   Sexo { get; }
    public int   Edad { get; }

    public RangoDeEdad RangoDeEdad { 
        get => Edad switch {
            <= 19 =>  RangoDeEdad.MuyJoven,
            >= 20 and <= 29 => RangoDeEdad.Joven,
            >= 30 and <= 39 => RangoDeEdad.Plenitud,
            >= 40 and <= 49 => RangoDeEdad.Madurez,
            >= 50 => RangoDeEdad.Vejez
        };
    }

    public Persona(string nombre, Sexo sexo, int edad)
    {
        this.Nombre = nombre;
        this.Sexo   = sexo;
        this.Edad   = edad; 
    }

    public override string ToString() => $"Sexo: {Sexo}, Edad: {Edad}, Rango: {RangoDeEdad}";
}
