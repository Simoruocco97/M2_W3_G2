using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    private enum DAMAGE_TYPE
    {
        SLASHING,
        PIERCING,
        BLUDGEONING,
        MAGICAL,
        FORCE,
    }
    [SerializeField] private DAMAGE_TYPE attackType, resistance, weakness;
    [SerializeField] private int baseDamage = 1;
    void Start()
    {
        if (attackType == resistance)
        {
            baseDamage = baseDamage / 2;
            Debug.Log("Il nemico e' resistente e dimezza i danni ricevuti! Danni inflitti: " + baseDamage);
        }
        else if (attackType == weakness)
        {
            baseDamage = baseDamage * 2;
            Debug.Log("Il nemico e' debole a questo tipo di attacco! Danni inflitti: " + baseDamage);
        }
        else
        {
            Debug.Log("Danni inflitti: " + baseDamage);
        }
    }
}