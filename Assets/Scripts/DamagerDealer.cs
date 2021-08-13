using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerDealer : MonoBehaviour
{
    int damage = 1;
    
    public int GetDamage()
    {
        return damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
