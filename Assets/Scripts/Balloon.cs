using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public float force;
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
        Debug.Log("Butts");

        if (c.gameObject.CompareTag("Player"))
        {
            Debug.Log("DoubleButts");
            c.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up*force, ForceMode2D.Impulse);
            Destroy(gameObject);
        }
    }
}
