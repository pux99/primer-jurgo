using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    float timer;
    public GameObject bulletPrefab;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer>= 2f)
        {
            timer = 0;
            Vector3 position = new Vector3(150, 0, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(bulletPrefab,position,rotation);
        }
    }
}
