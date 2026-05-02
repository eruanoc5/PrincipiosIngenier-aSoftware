using System;
using System.Collections.Generic;

public class GestorProductos
{
    private List<string> lista_productos = new List<string>();
    private List<string> historial = new List<string>();

    public string AgregarProducto(string nombre)
    {
        if (nombre == "")
        {
            return "Error";
        }
        if (nombre == "")
        {
            return "Error";
        }

        if (ValidacionAvanzada(nombre))
        {
            lista_productos.Add(nombre);
            historial.Add("Producto agregado");
            return "OK";
        }
        else
        {
            return "No válido";
        }
    }

    public string AgregarProductoV2(string nombre)
    {
        if (nombre == "")
        {
            return "Error";
        }

        lista_productos.Add(nombre);
        historial.Add("Producto agregado");
        return "OK";
    }

    public void MostrarProductos()
    {
        foreach (var p in lista_productos)
        {
            Console.WriteLine("Producto: " + p);
        }
    }

    public void MostrarProductosDetallado()
    {
        foreach (var p in lista_productos)
        {
            Console.WriteLine("Producto: " + p);
        }
    }

    public bool ValidacionAvanzada(string nombre)
    {
        if (nombre != "")
        {
            if (nombre.Length > 0)
            {
                if (nombre != null)
                {
                    if (nombre != "test")
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public void GenerarEstadisticas()
    {
        Console.WriteLine("Generando estadísticas...");
    }

    public void SincronizarApiExterna()
    {
        Console.WriteLine("Sincronizando con API externa...");
    }

    public void ProcesoExtra(string nombre)
    {
        if (nombre != "")
        {
            if (nombre != null)
            {
                if (nombre.Length > 0)
                {
                    Console.WriteLine("Procesando producto...");
                }
            }
        }
    }
}
