using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mannager : MonoBehaviour
{
    Arbol arbolito = new Arbol();
    // Start is called before the first frame update
    void Start()
    {
        arbolito.AddArboles(5);
        arbolito.AddArboles(6);
        arbolito.AddArboles(3);
        arbolito.AddArboles(9);
        arbolito.AddArboles(10);
        arbolito.AddArboles(1);
        arbolito.AddArboles(11);
        arbolito.AddArboles(4);
        arbolito.AddArboles(15);
        arbolito.AddArboles(2);
        arbolito.AddArboles(8);
        arbolito.PrintOne();
        arbolito.PrintTwo();
        arbolito.PrintThree();
        arbolito.PrintFour();
        arbolito.DeleteArbol(3);
        arbolito.PrintOne();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
