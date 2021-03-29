using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockOrUnlockCamara : MonoBehaviour
{
    bool unlockCamara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {
            unlockCamara = !unlockCamara;
        }
        if (unlockCamara == true)
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
        }
        else
        {
            gameObject.transform.position = new Vector3(GameObject.Find("player").transform.position.x, GameObject.Find("player").transform.position.y, -9.13051f);
        }
    }
}
