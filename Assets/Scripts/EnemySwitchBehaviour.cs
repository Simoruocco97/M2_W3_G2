using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySwitchBehaviour : MonoBehaviour
{
    [SerializeField] private enum STATE
    {
        IDLE,
        AGGROED,
        ATTACKING,
        DEFEATED,
    }
    [SerializeField] private STATE stato;

    void Update() //ad ogni frame tramite if-else-if stampa un messaggio in base al valore della variabile state
    {
        if (stato == STATE.IDLE)
        {
            Debug.Log("Il nemico e' fermo.");
        }
        else if (stato == STATE.AGGROED)
        {
            Debug.Log("Il nemico insegue il giocatore.");
        }
        else if ( stato == STATE.ATTACKING)
        {
            Debug.Log("Il nemico sta attaccando il giocatore.");
        }
        else if ( stato == STATE.DEFEATED)
        {
            Debug.Log("Il nemico e' sconfitto");
        }
    }
}
