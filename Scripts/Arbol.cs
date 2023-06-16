using System.Collections;
using System.Collections.Generic;
using System.Text;
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
    NodoArbol FindParent(int num)
    {
        // NodoArbol temp = null;
        NodoArbol actual = adam;

        while (actual != null)
        {
            // Debug.Log(actual.left.dato + "valor de la izquierda," + actual.right.dato + "valor de la derecha" + "  " + num + " El valor a buscar");
            // if (actual.left != null || actual.right != null)
            //{
            if (actual.left != null)
            {
                if (num == actual.left.dato)
                {
                    Debug.Log(actual.dato);
                    return actual;
                }

            }
            if (actual.right != null)
            {
                if (num == actual.right.dato)
                {
                    Debug.Log(actual.dato);
                    return actual;
                }
            }
            //if (num == actual.left.dato || num == actual.right.dato)
            //{
            //    Debug.Log(actual.dato);
            //    return actual;
            //}
            if (num > actual.dato)
            {

                actual = actual.right;
            }
            else
            {

                actual = actual.left;
            }
            // }
        }

        Debug.Log("No existe dicho valor en el arbol");
        return null;
    }

    private void PrintOne(NodoArbol tree, StringBuilder T)
    {

        if (tree != null)
        {
            // Debug.Log(tree.dato);
            T.Append($",{tree.dato}");
            PrintOne(tree.left, T);
            PrintOne(tree.right, T);

        }
        //while(tree != null)
        //{
        //    T.Append($",{tree.dato}");

        //}

    }
    public void PrintOne()
    {
        StringBuilder builder = new StringBuilder("Los valores del arbol en el orden de raiz son: ");
        PrintOne(adam, builder);
        Debug.Log(builder.ToString());
    }
    private void PrintTwo(NodoArbol tree, StringBuilder T)
    {

        if (tree != null)
        {
            // Debug.Log(tree.dato);
            PrintTwo(tree.left, T);
            T.Append($",{tree.dato}");
            PrintTwo(tree.right, T);

        }

    }
    public void PrintTwo()
    {
        StringBuilder builder = new StringBuilder("Los valores del arbol de menor a mayor: ");
        PrintTwo(adam, builder);
        Debug.Log(builder.ToString());
    }
    private void PrintThree(NodoArbol tree, StringBuilder T)
    {

        if (tree != null)
        {
            // Debug.Log(tree.dato);
            PrintThree(tree.left, T);
            PrintThree(tree.right, T);
            T.Append($",{tree.dato}");

        }

    }
    public void PrintThree()
    {
        StringBuilder builder = new StringBuilder("No se que orden llevan :v pero pues aqui estan : ");
        PrintThree(adam, builder);
        Debug.Log(builder.ToString());
    }
    private void PrintFour(NodoArbol tree, StringBuilder T)
    {

        if (tree != null)
        {
            // Debug.Log(tree.dato);
            PrintFour(tree.right, T);
            T.Append($",{tree.dato}");
            PrintFour(tree.left, T);


        }

    }
    public void PrintFour()
    {
        StringBuilder builder = new StringBuilder("Los valores del arbol de mayor a menor: ");
        PrintFour(adam, builder);
        Debug.Log(builder.ToString());
    }

    NodoArbol FindMinValue(NodoArbol tree)
    {
        while (tree.left != null)
        {
            tree = tree.left;
        }
        Debug.Log(tree.dato);
        return tree;
    }
    public void DeleteArbol(int num)
    {
        NodoArbol child = Find(num);
        NodoArbol parent = FindParent(num); // solo pasar 1 vez por el arbol


        if (child.left == null && child.right == null) //caso sin ninguna hoja
        {
            Debug.Log("Entre en el primer caso");
            if (child != adam)
            {
                if (parent.right == child)
                {
                    parent.SetRight(null);
                }
                else
                {
                    parent.SetLeft(null);
                }
            }
            else
            {
                adam = null;
            }

            return;
        }
        if (child.left == null) //caso con 1 hoja
        {
            if (child != adam)
            {
                Debug.Log("Entre en el segundo caso");
                parent.SetRight(child.right);
                return;
            }
            else
            {
                adam = child;
            }
            return;
        }
        if (child.right == null) //caso con 1 hoja
        {
            if (child != adam)
            {
                Debug.Log("Entre en el segundo caso");
                parent.SetLeft(child.right);
            }
            else
            {
                adam = child;
            }

            return;
        }
        Debug.Log("Entre en el tercer caso");
        // Forma recursiva pero solo valido para un valor del nodo
        {
            //NodoArbol temp = FindMinValue(child.right);
            // int valueTemp = temp.dato;
            // Debug.Log("El valor a promover es: " + valueTemp);

            //DeleteArbolR(valueTemp);
            //child.SetDato(valueTemp);
        }

        NodoArbol temp = FindMinValue(child.right);
        NodoArbol tempParent = FindParent(temp.dato);
       
       

        if (child != adam)
        {
            if (parent.right == child)
            {
                tempParent.SetLeft(null);
                parent.SetRight(temp);
                Debug.Log("valor de la der nueva padre" + parent.right.dato);


            }
            else
            {
                tempParent.SetRight(null);
                parent.SetLeft(temp);
                Debug.Log("valor de la izq nueva padre" + parent.left.dato);
            }

            temp.SetLeft(child.left);
            //Debug.Log("valor de la izq nueva hoja" + temp.left.dato);
            temp.SetRight(child.right);
            // Debug.Log("valor de la derecha nueva hoja" + temp.right.dato);


            return;
        }
        else
        {
            adam = temp;
        }

    }

}
