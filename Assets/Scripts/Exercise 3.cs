using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDivideExercise : MonoBehaviour
{
    [SerializeField] private int variabile1;
    [SerializeField] private int variabile2;

    void Start()
    {

    }

    bool SafeDivide(int dividendo, int divisore, out int risultato)
    {
        if (divisore == 0)
        {
            risultato = 0;
            Debug.Log("Attenzione, il divisore non può essere 0!");
            return false;
        }
        risultato = dividendo / divisore;
        return true;
    }
}
