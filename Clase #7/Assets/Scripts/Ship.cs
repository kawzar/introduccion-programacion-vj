using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField]
    protected float speed;

    [SerializeField]
    protected Projectile projectile;


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        gameObject.transform.Translate(Vector3.zero);
    }

    protected void Shoot()
    {
        Instantiate(projectile, transform);
    }
}
