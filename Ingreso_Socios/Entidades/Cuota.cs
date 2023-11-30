using System;



public class Cuota
{
    private int? idCuota;
    private double? monto;
    private DateTime fechaVencimiento;
    private string periodio;
    private string medioPago;
    private DateTime fechaEmision;
    private DateTime? fechaPago;

    public Cuota()
    {
    }

    public Cuota(int? idCuota, double? monto, DateTime fechaVencimiento, string periodio, string medioPago, DateTime fechaEmision)
    {
        this.IdCuota = idCuota;
        this.Monto = monto;
        this.FechaVencimiento = fechaVencimiento;
        this.Periodio = periodio;
        this.MedioPago = medioPago;
        this.FechaEmision = fechaEmision;
        this.fechaPago = null;
    }

    public int? IdCuota { get => idCuota; set => idCuota = value; }
    public double? Monto { get => monto; set => monto = value; }
    public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    public string Periodio { get => periodio; set => periodio = value; }
    public string MedioPago { get => medioPago; set => medioPago = value; }
    public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
    public DateTime? FechaPago { get => fechaPago; set => fechaPago = value; }
}
