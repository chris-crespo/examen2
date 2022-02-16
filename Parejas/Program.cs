using Parejas;

var sistema = new Sistema();
sistema.PosibleParejas(sistema.Personas)
    .ForEach(p => Console.WriteLine(p));
