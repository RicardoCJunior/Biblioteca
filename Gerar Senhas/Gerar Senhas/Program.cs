using System;
using System.Text;

public class SenhaGerador
{
    public static string GerarSenha(int comprimento, byte[] dadosAleatorios, string caracteresPermitidos)
    {
        StringBuilder senha = new StringBuilder(comprimento);

        foreach (byte b in dadosAleatorios)
        {
           
            senha.Append(caracteresPermitidos[b % caracteresPermitidos.Length]);

            if (senha.Length >= comprimento)
                break;
        }

        
        while (senha.Length < comprimento)
        {
          
            senha.Append(caracteresPermitidos[new Random().Next(caracteresPermitidos.Length)]);
        }

        return senha.ToString();
    }
}


class Program
{
    static void Main()
    {
        string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        byte[] dadosAleatorios = { 1, 5, 9, 2, 4, 6 }; 
        int comprimento = 12; 

        string senha = SenhaGerador.GerarSenha(comprimento, dadosAleatorios, caracteresPermitidos);
        Console.WriteLine(senha);
    }
}
