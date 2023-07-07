using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVerticly : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
    }
}