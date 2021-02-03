using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRight = 10f;
    public float changetoChangeDirection;
    public float secondsBetweenAppleDrop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Change Directions
        if (pos.x < -leftAndRight)
        {
            speed = Mathf.Abs(speed);

        } else if (pos.x > leftAndRight)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    void FixedUpdate()
    {
        if(Random.value < changetoChangeDirection)
        {
            speed *= -1;
        }
    }
}
