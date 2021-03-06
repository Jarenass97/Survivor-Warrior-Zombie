using Assets.Scripts;
using System;
using System.Collections;
using UnityEngine;

[System.Serializable]
public class Partida
{
    public static Partida current;
    private bool hasArma;
    private int scene;
    private int ronda;
    private int puntos;
    private int puntosTotales;
    private int dificultad;
    private int granadas;
    private Afinidad afinidad;

    public Partida()
    {
        this.hasArma = false;
        this.scene = 0;
        this.ronda = 0;
        this.puntos = 0;
        this.puntosTotales = 0;
        this.dificultad = 0;
        this.granadas = 0;
        this.afinidad = Afinidad.SIN_AFINIDAD;
    }

    public static void setHasArma(bool hasArma)
    {
        current.hasArma = hasArma;
    }

    public static bool HasArma()
    {
        return current.hasArma;
    }

    public static void setScene(int scene)
    {
        current.scene = scene;
    }

    public static int getScene()
    {
        return current.scene;
    }

    public static Afinidad getAfinidad()
    {
        return current.afinidad;
    }
    public static void setAfinidad(Afinidad afinidad)
    {
        current.afinidad = afinidad;
    }

    public static void setRonda(int ronda)
    {
        current.ronda = ronda;
    }

    public static int getRonda()
    {
        return current.ronda;
    }
    public static void setPuntos(int puntos)
    {
        current.puntos = puntos;
    }

    public static int getPuntos()
    {
        return current.puntos;
    }
    public static void setPuntosTotales(int puntos)
    {
        current.puntosTotales = puntos;
    }

    public static int getPuntosTotales()
    {
        return current.puntosTotales;
    }
    public static void setDificultad(int dificultad)
    {
        current.dificultad = dificultad;
    }

    public static int getDificultad()
    {
        return current.dificultad;
    }
    public static void setGranadas(int granadas)
    {
        current.granadas = granadas;
    }

    public static int getGranadas()
    {
        return current.granadas;
    }

    public static bool isOnFirstScene()
    {
        return current.scene == 0;
    }

    public static bool existenDatos()
    {
        return SaveLoad.existeFichero();
    }
}
