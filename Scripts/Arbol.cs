using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbol
{
    private NodoArbol adam = new(); //el padre de todos 
                                    // private NodoArbol Child = new(); //el padre de todos 

    public Arbol()
    {
        adam = null;

    }

    /*Adam
 |           |
izq           der
|    |    |     |


{10}
Adam = 10
Actual = 10 
Temp = 11

*/
    public void AddArboles(int num)
    {
        NodoArbol temp = new(num);
        //NodoArbol   = new(num);
        if (adam == null)
        {
            adam = temp;

            return;
        }

        NodoArbol Actual = adam;

        while (Actual != null)
        {
            if (temp.dato > Actual.dato)
            {
                if (Actual.right == null)
                {
                    Actual.SetRight(temp);
                    break;
                }
                Actual = Actual.right;
            }
            else
            {
                if (Actual.left == null)
                {
                    Actual.SetLeft(temp);
                    break;
                }
                Actual = Actual.left;
            }
        }

    }
    public NodoArbol Find(int num)
    {
        NodoArbol actual = adam;
        while (actual != null)
        {
            if (num == actual.dato)
            {
                Debug.Log(actual.dato);
                return actual;
            }
            if (num > actual.dato)
            {
                actual = actual.right;
            }
            else
            {
                actual = actual.left;
            }
        }
        Debug.Log("No existe dicho valor en el arbol");
        return null;
    }

}
