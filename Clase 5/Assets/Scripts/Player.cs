using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float posX = transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        }
    }
}
