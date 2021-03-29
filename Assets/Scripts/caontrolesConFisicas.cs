using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caontrolesConFisicas : MonoBehaviour
{
    bool canJump;
    int numOfJumps;
    int energia=100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-400000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(400000f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if(!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }
        if (Input.GetKeyDown("up") && canJump )
        {
            numOfJumps += 1;
            if (gameObject.GetComponent<Rigidbody2D>().drag == 10)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1.2f*80000));
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 60000));
            }
            energia -= 20;
        }
        if(numOfJumps >=2)
        {
            canJump = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            canJump = true;
            numOfJumps = 0;
            gameObject.GetComponent<Rigidbody2D>().drag = 10f;
        }
        if (collision.transform.tag == "wallLeft")
        {
            canJump = true;
            numOfJumps = 1;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-50000, 3000));
            //energia += 20;
        }
        if (collision.transform.tag == "wallRigth")
        {
            canJump = true;
            numOfJumps = 1;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(50000, 3000));
            //energia += 20;
        }
        if (collision.transform.tag == "ice")
        {
            gameObject.GetComponent<Rigidbody2D>().drag = 3f;
            canJump = true;
            numOfJumps = 0;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "bullet")
        {
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10000, 0));
            //energia += 20;
        }
    }
}
