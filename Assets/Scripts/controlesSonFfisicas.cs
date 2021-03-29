using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlesSonFfisicas : MonoBehaviour
{
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.transform.Translate(-50f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.Translate(50f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("up"))
           {
               gameObject.transform.Translate(0, 50f * Time.deltaTime, 0);
           }
        if (Input.GetKey("down"))
           {
               gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
           }
        ManageJump();
    }
    void ManageJump()
    {
        if (gameObject.transform.position.y <= 0)
        {
            canJump = true;
        }
        if(Input.GetKey("up") && canJump && gameObject.transform.position.y <10)
        {
            gameObject.transform.Translate(0, 50f *Time.deltaTime, 0);
        }
        else
        {
            canJump = false;
            
            if(gameObject.transform.position.y >0)
            {
                gameObject.transform.Translate(0, -50f * Time.deltaTime, 0);
            }
        }
    }
}
