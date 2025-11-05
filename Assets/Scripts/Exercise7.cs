using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    private enum STATE
    {
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED,
    }
    [SerializeField] private STATE stato;

    void Update()
    {
        switch (stato)                     //esercizio 5
        {
            case STATE.IDLE:
                Debug.Log("Il nemico e' fermo.");
                break;

            case STATE.AGGROED:
                Debug.Log("Il nemico insegue il giocatore.");
                break;

            case STATE.ATTACKING:
                Debug.Log("Il nemico sta attaccando il giocatore.");
                break;

            case STATE.DEFEATED:
                Debug.Log("Il nemico e' sconfitto.");
                break;
        }
    }
}
