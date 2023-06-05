using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoArbol
{
    public int dato { get; private set; } 
    public NodoArbol left { get; private set; }
    public NodoArbol right { get; private set; }

    public NodoArbol()
    {

    }
    public NodoArbol(int num)
    {
        dato = num;
    }
    public void SetLeft(NodoArbol temp)
    {
        left = temp;
    }
    public void SetRight(NodoArbol temp)
    {
        right = temp;
    }
    public void SetDato(int num)
    {
        dato = num;
    }
}

