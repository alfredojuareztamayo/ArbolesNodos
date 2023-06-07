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

    //private void PrintTree(Queue q1)
    //{
    //    string treeText = " ";
    //    NodoArbol tree = adam;
    //   // NodoArbol temp = null;
    //    while(tree != null)
    //    {
    //        if(tree.left.dato < tree.dato)
    //        {
    //            tree = tree.left;
    //        }
    //        else
    //        {
    //            tree = tree.right;
    //        }
    //        /*if(tree.right.dato < tree.dato)
    //        {
    //            tree = tree.right;
    //        }*/
            
    //    }
       
    //}
    private void PrintOne(NodoArbol tree, StringBuilder T)
    {
        
        if(tree!= null)
        {
           // Debug.Log(tree.dato);
            T.Append($",{tree.dato}");
            PrintOne(tree.left, T);
            PrintOne(tree.right, T);

        }
       
    }
    public void PrintOne()
    {
        StringBuilder builder = new StringBuilder("Los valores del arbol en el orden de raiz son: ");
        PrintOne(adam, builder);
        Debug.Log(builder.ToString() );
    }
     private void PrintTwo(NodoArbol tree, StringBuilder T)
    {
        
        if(tree!= null)
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
        Debug.Log(builder.ToString() );
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
}
