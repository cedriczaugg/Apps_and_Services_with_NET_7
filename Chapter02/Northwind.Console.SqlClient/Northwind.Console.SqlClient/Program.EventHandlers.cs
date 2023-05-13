// <copyright file="Program.EventHandlers.cs" company="Packt">
// Copyright (c) Packt. All rights reserved.
// </copyright>

using System.Data;
using Microsoft.Data.SqlClient;

/// <summary>
/// Event handlers for the main program.
/// </summary>
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
        foreach (SqlError error in e.Errors)
        {
            WriteLine($"  Error: {error.Message}");
        }

        ForegroundColor = previousColor;
    }
}