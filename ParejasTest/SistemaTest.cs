using System.Collections.Generic;
using Xunit;
using Parejas;

namespace ParejasTest;

public class SistemaTest
{
    [Theory]
    [MemberData(nameof(Data))]
    public void AdmitenDescendenciaTest(Persona a, Persona b, bool esperado)
    {
        // Given
        var sis = new Sistema();
        // When
        var result = sis.AdmitenDescendencia(a,b);
        // Then
        Assert.Equal(esperado, result);
    }

    public static IEnumerable<object[]> Data =>
    new List<object[]>
    {
        new object[] { new Persona("A", Sexo.M, 20) , new Persona("B", Sexo.M, 20), false },
        new object[] { new Persona("A", Sexo.H, 30) , new Persona("B", Sexo.M, 80), false },
        new object[] { new Persona("A", Sexo.H, 30) , new Persona("B", Sexo.M, 20), true },
    };
}
