using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVerticly : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float maxSpeed = 45;
    public float minSpeed = 30;
    public float slipChance = 1;
    private Rigidbody2D moveRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        moveRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed += Random.Range(-0.12f, 0.1f);
        speed = Mathf.Max(Mathf.Min(speed, maxSpeed), minSpeed);
        float distance = target.transform.position.y - transform.position.y;
        Vector2 force = Vector2.up * speed * distance/Mathf.Abs(distance);
        float slip = Random.Range(0,100);
        if (slip < slipChance)
        {
            force *= 0.1f;
        }
        moveRigidbody.AddForce(force);
    }
}
