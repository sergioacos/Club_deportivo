using System;

public class Actividad
{
    private int? idActividad;
    private string? nombre;
    private double? costo;
    private List<NoSocio> clientes;

    public Actividad(string nombre, double costo, List<NoSocio> clientes)
	{
        this.Nombre = nombre;
        this.Costo = costo;
        this.clientes = clientes;
        
	}



    public string? Nombre { get => nombre; set => nombre = value; }
    public double? Costo { get => costo; set => costo = value; }
    public List<NoSocio> Clientes { get => clientes; set => clientes = value; }
}
