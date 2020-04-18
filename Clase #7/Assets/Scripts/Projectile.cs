using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform forwardRef;

    [SerializeField]
    protected float speed = 3f;

    [SerializeField]
    protected float damage = 10f;

    // Start is called before the first frame update
    void Start()
    {
        if (forwardRef == null)
        {
            forwardRef = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = forwardRef.forward * speed;
    }
}
