using System;
using System.Collections.Generic;

public static class Utente
{
    private static bool isLogged = false;
    private static DateTime loginTime;
    private static List<DateTime> accessi = new List<DateTime>();

    public static void Login()
    {
        if (isLogged)
        {
            Console.WriteLine("Utente già loggato.");
            return;
        }

        Console.WriteLine("\nInserisci username:");
        var username = Console.ReadLine();
        Console.WriteLine("\nInserisci password:");
        var password = Console.ReadLine();
        Console.WriteLine("\nConferma password:");
        var confirmPassword = Console.ReadLine();

        if (string.IsNullOrEmpty(username) || password != confirmPassword)
        {
            Console.WriteLine("\nUsername non inserito o le password non coincidono.");
            return;
        }

        isLogged = true;
        loginTime = DateTime.Now;
        accessi.Add(loginTime);
        Console.WriteLine("\nLogin effettuato con successo.");
    }

    public static void Logout()
    {
        if (!isLogged)
        {
            Console.WriteLine("\nNessun utente loggato.");
            return;
        }

        isLogged = false;
        Console.WriteLine("\nLogout effettuato con successo.");
    }

    public static void VerificaLogin()
    {
        if (!isLogged)
        {
            Console.WriteLine("\nNessun utente loggato.");
            return;
        }

        Console.WriteLine($"\nLogin effettuato il {loginTime}.");
    }

    public static void StampaAccessi()
    {
        if (accessi.Count == 0)
        {
            Console.WriteLine("\nNessun accesso registrato.");
            return;
        }

        Console.WriteLine("\nStorico accessi:");
        foreach (var accesso in accessi)
        {
            Console.WriteLine(accesso);
        }
    }
}
