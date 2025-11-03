using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariabileSwap2 : MonoBehaviour
{
    void Start()
    {
        int a = 10;
        int b = 17;

        Debug.Log("A = " + a + " e B = " + b);

        int c;
        c = a;
        a = b;
        b = c;

        Debug.Log("A = " + a + " e B = " + b);

        Debug.Log("Ora con la funzione void normale");
        Swap(a, b);  // in questo caso non ci viene restituito alcun valore perche' solo "n" ed "m" nella funzione Swap vengono scambiati, ma poi la funzione non restituisce nulla nello Start

        Debug.Log("Ora con la funzione void ref");
        Swap(ref a, ref b);  // in questo caso invece la funzione va a lavorare proprio sulle coordinate di "a" e "b", ciò consente di rendere visibile lo scambio anche in Start
    }

    void Swap(int n, int m)
    {
        int t = n;
        n = m;
        m = t;
    }

    void Swap(ref int n, ref int m)
    {
        int t = n;
        n = m;
        m = t;
    }
}