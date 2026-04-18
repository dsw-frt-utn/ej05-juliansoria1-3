using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class VehiculoCombustible: Vehiculo
{
    private double kilometrosPorLitro;
    private double litrosExtra;

    public VehiculoCombustible(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kilometrosPorLitro, double litrosExtra) : base(VehiculoTipo.Combustible, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kilometrosPorLitro = kilometrosPorLitro;
        this.litrosExtra = litrosExtra;
    }

    public double GetKilometrosPorLitro()
    {
        return kilometrosPorLitro;
    }

    public double GetLitrosExtra()
    {
        return litrosExtra;
    }

    public override double CalcularConsumo(double kilometros)
    {
        int AnioActual = System.DateTime.Now.Year;
        int Antiguedad = AnioActual - GetAnio();

        if (Antiguedad > 5)
        {
            return (kilometros / kilometrosPorLitro) + ((kilometros * litrosExtra) / 15);
        }
        else
        {
            return kilometros / kilometrosPorLitro;
        }
    }
}
