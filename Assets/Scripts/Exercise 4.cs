using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class LetsPlayWithArrays : MonoBehaviour
{
    [SerializeField] int[] array;
    [SerializeField] int numberToFind;
    [SerializeField] int indexToTheBack;
    [SerializeField] int shiftTimes;
    void Start()
    {
        Debug.Log("ora utilizzo la funzione Find");
        Find(array, numberToFind);
        Debug.Log("ora utilizzo la funzione PutToTheBack");
        PutToTheBack(array, indexToTheBack);
        StampArray(array);
        Debug.Log("ora utilizzo la funzione ShiftOnce");
        ShiftOnce(array);
        StampArray(array);
        Debug.Log("ora utilizzo la funzione Shift " + shiftTimes + " volte");
        Shift(array, shiftTimes);
        StampArray(array);
    }

    int Find(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                Debug.Log("Il numero si trova nell'Element " + i);
                return i;
            }
        }
        Debug.Log("Il numero non e' presente nell'array");
        return -1; //restituisce un numero sicuramente fuori dall'array, -1
    }

    void SwapDueNumeriArray(int[] array, int posizioneDaSwappare) //scambia semplicemente due numeri in un array
    {
        if (posizioneDaSwappare >= array.Length - 1 && posizioneDaSwappare >= 0)
        {
            Debug.Log("Il numero e' gia' nell'ultima posizione");
        }
        else
        {
            int temp = array[posizioneDaSwappare];
            array[posizioneDaSwappare] = array[posizioneDaSwappare + 1];
            array[posizioneDaSwappare + 1] = temp;
        }
    }

    void PutToTheBack(int[] array, int index) //faccio ciclare l'array con la funzione SwapDueNumeriArray
    {
        {
            int temp = array[index];
            for (int i = index; i < array.Length - 1; i++)
            {
                SwapDueNumeriArray(array, i);
            }
        }
    }

    void ShiftOnce(int[] array)
    {
        int temp = array[array.Length - 1]; //salvo l'ultimo valore della "casella" dell'array in un temp

        for (int i = array.Length - 1; i > 0; i--) //faccio partire il ciclo dell'array da destra verso sinistra partendo dal penultimo ed incrementando la posizione di 1, così da non perdere dati
        {
            array[i] = array[i - 1];
        }
        array[0] = temp; //associo all'array 0 la posizione del temp, il vecchio array.length-1
    }

    void Shift(int[] array, int times)
    {
        for (int i = 0; i < times; i++) //creo un nuovo ciclo che fa shiftare times volte l'array
        {
            ShiftOnce(array);
        }
    }

    //opzionale per testing

    void StampArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }
}