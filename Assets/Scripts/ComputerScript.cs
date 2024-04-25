using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScript : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 move = Vector3.zero;
    public float speed;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float d = Ball.transform.position.y - transform.position.y;
        if(d>0)
        {
            move.y = speed * Mathf.Min(d, 1.0f);
        }
        if(d<0)
        {
            move.y = -(speed * Mathf.Min(-d, 1.0f));
        }
        transform.position += move * Time.deltaTime;
    }
}
