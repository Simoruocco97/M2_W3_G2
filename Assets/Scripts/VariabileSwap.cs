using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariabileSwap : MonoBehaviour
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
    }
}
