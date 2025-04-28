using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioTaxis : MonoBehaviour
{
    public uint taxis = 1;
    public uint dias = 5;
    public uint distTaxi = 85;
    public float costeCombustible = 130;
    public uint distCombustible = 15;
    public float descuento = 0.20f;
    uint descuentoThreshold = 100;
    // Start is called before the first frame update
    void Start()
    {
        if(dias < 5)
        {
            print("La cantidad de días no puede ser menor a 5");
            return;
        }
        if(taxis < 1)
        {
            print("La cantidad de taxis no puede ser menor a 1");
            return;
        }
        float combustible = ((float)distTaxi / (float)distCombustible);
        float coste = combustible * costeCombustible;
        float costeNoDescuento = coste;
        if (combustible >= descuentoThreshold) coste *= (1 - descuento);
        Debug.Log($"Una flota de {taxis} unidades trabajando durante {dias} días implicará un gasto de ${costeNoDescuento} pesos en concepto de combustible");
        if (coste == costeNoDescuento) return;
        Debug.Log($"Debido a que se consumirían {combustible} litros de combustible, el convenio nos garantiza un descuento del {descuento * 100}%, haciendo que el coste total sean ${coste} pesos");
    }
}
