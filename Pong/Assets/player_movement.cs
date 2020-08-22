using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{

    Rigidbody2D prb;

    float paddleMinY = 8.8f;
    float paddleMaxY = 17.4f;
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        prb = this.GetComponent<Rigidbody2D>();
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(transform.position.y > paddleMaxY)
            {
                prb.velocity = Vector3.zero;
                this.transform.position = new Vector3(this.transform.position.x, paddleMaxY, this.transform.position.z);

            }
            else
            {
                prb.velocity = new Vector2(0, speed);
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (transform.position.y < paddleMinY)
            {

                prb.velocity = Vector3.zero;
                this.transform.position = new Vector3(this.transform.position.x, paddleMinY, this.transform.position.z);
            }
            else
            {
                prb.velocity = new Vector2(0, -1 * speed);
            }
        }
    }
}
