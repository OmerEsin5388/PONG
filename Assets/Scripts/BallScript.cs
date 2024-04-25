using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BallStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void BallStart()
    {
      float x = Random.Range(0,2) == 0? -1 : 1;
      float y = Random.Range(0,2) == 0? -1 : 1;
      rb.velocity = new Vector2(speed * x, speed * y);
    }
}
