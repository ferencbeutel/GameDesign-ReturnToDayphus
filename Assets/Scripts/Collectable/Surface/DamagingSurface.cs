﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingSurface : MonoBehaviour {

    public float damage;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Damageable>() != null)
        {
            collision.gameObject.GetComponent<Damageable>().ApplyDamage(damage);
        }
    }
}
