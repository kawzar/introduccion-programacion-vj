using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenShip : Ship
{
    public Transform player;

    private void Start()
    {
        if (player == null)
        {
            player = transform;
        }
    }
    protected override void Move()
    {
        transform.LookAt(player);
        transform.Translate(transform.forward * speed);
    }
}
