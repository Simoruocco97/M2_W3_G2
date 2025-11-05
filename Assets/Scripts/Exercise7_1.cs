using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7_1 : MonoBehaviour
{
    private enum DAMAGE_TYPE
    {
        SLASHING,
        PIERCING,
        BLUDGEONING,
        MAGICAL,
        FORCE,
        NONE,
    }
    [SerializeField] private DAMAGE_TYPE attackType, resistance, weakness;
    [SerializeField] private int baseDamage = 1;

    void Start()
    {
        switch (attackType) 
        {
            case DAMAGE_TYPE.SLASHING:
                switch (resistance)
                {
                    case DAMAGE_TYPE.SLASHING:
                        baseDamage /= 2;
                        Debug.Log("Il nemico e' resistente e dimezza i danni ricevuti! Danni inflitti: " + baseDamage);
                        break;
                }
                switch (weakness)
                {
                    case DAMAGE_TYPE.SLASHING:
                        baseDamage *= 2;
                        Debug.Log("Il nemico e' debole a questo tipo di attacco! Danni inflitti: " + baseDamage);
                        break;
                }
                break;

            case DAMAGE_TYPE.PIERCING:
                switch (resistance)
                {
                    case DAMAGE_TYPE.PIERCING:
                        baseDamage /= 2;
                        Debug.Log("Il nemico e' resistente e dimezza i danni ricevuti! Danni inflitti: " + baseDamage);
                        break;
                }
                switch (weakness)
                {
                    case DAMAGE_TYPE.PIERCING:
                        baseDamage *= 2;
                        Debug.Log("Il nemico e' debole a questo tipo di attacco! Danni inflitti: " + baseDamage);
                        break;
                }
                break;

            case DAMAGE_TYPE.BLUDGEONING:
                switch (resistance)
                {
                    case DAMAGE_TYPE.BLUDGEONING:
                        baseDamage /= 2;
                        Debug.Log("Il nemico e' resistente e dimezza i danni ricevuti! Danni inflitti: " + baseDamage);
                        break;
                }
                switch (weakness)
                {
                    case DAMAGE_TYPE.BLUDGEONING:
                        baseDamage *= 2;
                        Debug.Log("Il nemico e' debole a questo tipo di attacco! Danni inflitti: " + baseDamage);
                        break;
                }
                break;

            case DAMAGE_TYPE.MAGICAL:
                switch (resistance)
                {
                    case DAMAGE_TYPE.MAGICAL:
                        baseDamage /= 2;
                        Debug.Log("Il nemico e' resistente e dimezza i danni ricevuti! Danni inflitti: " + baseDamage);
                        break;
                }
                switch (weakness)
                {
                    case DAMAGE_TYPE.MAGICAL:
                        baseDamage *= 2;
                        Debug.Log("Il nemico e' debole a questo tipo di attacco! Danni inflitti: " + baseDamage);
                        break;
                }
                break;

            case DAMAGE_TYPE.FORCE:
                switch (resistance)
                {
                    case DAMAGE_TYPE.FORCE:
                        baseDamage /= 2;
                        Debug.Log("Il nemico e' resistente e dimezza i danni ricevuti! Danni inflitti: " + baseDamage);
                        break;
                }
                switch (weakness)
                {
                    case DAMAGE_TYPE.FORCE:
                        baseDamage *= 2;
                        Debug.Log("Il nemico e' debole a questo tipo di attacco! Danni inflitti: " + baseDamage);
                        break;
                }
                break;
        }
    }
}
