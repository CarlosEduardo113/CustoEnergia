using System;

class Program
{
    static void Main()
    {
        double consumoAparelho = 17.1; 
        int horasUsoDiario = 8; 
        double custoEnergia = 0.62258; 

        double consumoReal = (consumoAparelho / 30) * horasUsoDiario * 30;
        
        double custoEstimado = consumoReal * custoEnergia;

        Console.WriteLine("--- Custo de Energia ---");
        Console.WriteLine("Consumo do aparelho (em kWh/mês)...: " + consumoAparelho.ToString("F1"));
        Console.WriteLine("Horas de uso por dia...............: " + horasUsoDiario);
        Console.WriteLine("Custo da energia (em R$/kWh).......: " + custoEnergia.ToString("F5"));
        Console.WriteLine("\nCusto estimado: R$" + custoEstimado.ToString("F2"));
    }
}