using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowShip : Ship
{
    protected override void Move()
    {
        transform.Translate(Vector3.right * 10);
    }
}
