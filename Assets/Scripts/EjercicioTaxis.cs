﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioTaxis : MonoBehaviour
{
    public uint taxis = 1;
    public uint dias = 5;
    uint distTaxi = 90;
    float costeCombustible = 130;
    uint distCombustible = 15;
    float descuento = 0.20f;
    uint descuentoThreshold = 100;
    uint minDias = 5;
    uint minTaxis = 1;
    // Start is called before the first frame update
    void Start()
    {
        if(dias < minDias)
        {
            print($"La cantidad de días no puede ser menor a {minDias}");
            return;
        }
        if(taxis < minTaxis)
        {
            print($"La cantidad de taxis no puede ser menor a {minTaxis}");
            return;
        }
        float combustible = ((float)distTaxi / (float)distCombustible) * dias * taxis;
        float coste = combustible * costeCombustible;
        float costeNoDescuento = coste;
        if (combustible >= descuentoThreshold) coste *= (1 - descuento);
        Debug.Log($"Una flota de {taxis} unidades trabajando durante {dias} días implicará un gasto de ${costeNoDescuento} pesos en concepto de combustible");
        if (coste == costeNoDescuento) return;
        Debug.Log($"Debido a que se consumirían {combustible} litros de combustible, el convenio nos garantiza un descuento de ${costeNoDescuento * descuento} pesos, haciendo que el coste total sean ${coste} pesos");
    }
}
