using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitilalVelocity : MonoBehaviour
{
    public Vector2 initailVelocity = new(1, 1);
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = initailVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
