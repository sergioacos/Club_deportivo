using System;

public class NoSocio
{
    private int? idNoSocio;
    private List<Actividad> actividades;

    public NoSocio(string nombre, string apellido, DateTime fechaNac, int dni, bool aptoFisico, List<Actividad> actividades)
	{
        Nombre = nombre;
        Apellido = apellido;
        FechaNac = fechaNac;
        Dni = dni;
        AptoFisico = aptoFisico;
        Actividades = actividades;

    }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public int? Dni { get => dni; set => dni = value; }
    public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
    public List<Actividad> Actividades { get => actividades; set => actividades = value; }
}
