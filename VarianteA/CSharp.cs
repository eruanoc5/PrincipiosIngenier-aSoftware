using System;
using System.Collections.Generic;

public class GestorClientes
{
    private List<string> lista_clientes = new List<string>();
    private List<string> log_interno = new List<string>();

    public string AgregarCliente(string nombre)
    {
        if (nombre == "")
        {
            return "Error: vacío";
        }
        if (nombre == "")
        {
            return "Error: vacío";
        }

        if (ValidarNombreComplejo(nombre))
        {
            lista_clientes.Add(nombre);
            log_interno.Add("Cliente agregado");
            return "OK";
        }
        else
        {
            return "No válido";
        }
    }

    public string AgregarClienteV2(string nombre)
    {
        if (nombre == "")
        {
            return "Error: vacío";
        }

        lista_clientes.Add(nombre);
        log_interno.Add("Cliente agregado");
        return "OK";
    }

    public void MostrarClientes()
    {
        foreach (var c in lista_clientes)
        {
            Console.WriteLine("Cliente: " + c);
        }
    }

    public void MostrarClientesDetallado()
    {
        foreach (var c in lista_clientes)
        {
            Console.WriteLine("Cliente: " + c);
        }
    }

    public bool ValidarNombreComplejo(string nombre)
    {
        if (nombre != "")
        {
            if (nombre.Length > 0)
            {
                if (nombre != null)
                {
                    if (nombre != "admin")
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public void GenerarReporteFuturo()
    {
        Console.WriteLine("Generando reporte avanzado...");
    }

    public void SincronizarNube()
    {
        Console.WriteLine("Sincronizando con la nube...");
    }

    public void ProcesoInnecesario(string nombre)
    {
        if (nombre != "")
        {
            if (nombre != null)
            {
                if (nombre.Length > 0)
                {
                    Console.WriteLine("Procesando cliente...");
                }
            }
        }
    }
}
