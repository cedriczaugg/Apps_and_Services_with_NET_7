using System.Data;
using Microsoft.Data.SqlClient;

internal partial class Program
{
    private static void Connection_StateChange(object sender, StateChangeEventArgs e)
    {
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"State change from {e.OriginalState} to {e.CurrentState}.");
        ForegroundColor = previousColor;
    }

    private static void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
    {
        var previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkBlue;
        WriteLine($"Info: {e.Message}.");
        foreach (SqlError error in e.Errors) WriteLine($"  Error: {error.Message}");
        ForegroundColor = previousColor;
    }
}