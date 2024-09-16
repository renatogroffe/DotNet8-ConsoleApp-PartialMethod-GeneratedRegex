using ConsoleAppPartialMethod.Helpers;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 8 + GeneratedRegexAttribute + Partial Method *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

var selectedDatabases = new string[] { "sqlserver", "mongodb", "postgres", "redis", "mysql" };
foreach (var opcao in selectedDatabases)
{
    var oldColor = Console.ForegroundColor;
    if (ValidationHelpers.IsRelationalDatabase().IsMatch(opcao))
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{opcao} = alternativa valida");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{opcao} = alternativa invalida");
    }
    Console.ForegroundColor = oldColor;
}