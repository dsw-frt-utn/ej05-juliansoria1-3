using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class VehiculoElectrico : Vehiculo
{
    private double kwhBase;

    public VehiculoElectrico(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kwhBase) : base(VehiculoTipo.Electrico, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kwhBase = kwhBase;
    }

    public double GetKwhBase()
    {
        return kwhBase;
    }

    public override double CalcularConsumo(double kilometros)
    {
        if (GetCapacidadCarga() > 1200)
        {
            return (kwhBase) + (kwhBase * 0.15);
        }
        else {
            return kwhBase;
        }
     }
}
