using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleShip : Ship
{
    protected override void Move()
    {
        transform.position = Vector3.one * Mathf.Sin(Time.time) * speed;
    }
}
