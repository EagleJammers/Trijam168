using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    private float force = 15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            c.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(c.gameObject.GetComponent<Rigidbody2D>().velocity.x, force);
            c.gameObject.GetComponent<Movement>().resetHSpeed();
            Destroy(gameObject);
        }
    }
}
