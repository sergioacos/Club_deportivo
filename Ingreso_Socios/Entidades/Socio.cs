using System;

public class Socio:Persona
{
    private int? idSocio;
    private List<Cuota> cuotas;

    public Socio() { }

    public Socio(string nombre, string apellido, DateTime fechaNac, int dni, bool aptoFisico, List<Cuota> cuotas)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaNac = fechaNac;
        Dni = dni;
        AptoFisico = aptoFisico;
        cuotas = cuotas;
	}

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public int? Dni { get => dni; set => dni = value; }
    public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
    public List<Cuota> Cuotas { get => cuotas; set => cuotas = value; }
}
