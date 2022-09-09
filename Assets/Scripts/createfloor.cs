using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createfloor : MonoBehaviour
{
    public GameObject ground;
    private float increment = 3f;
    // Start is called before the first frame update
    //void Start()
    //{


    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            //InvokeRepeating("Ground", 0, 2);
            Ground();
        }

    }

    // Update is called once per frame
    void Ground()
    {
        float Spawn = transform.position.x + increment;
        Instantiate(ground, transform.position = new Vector3(Spawn, -3.6f, 1f), Quaternion.identity);
        Debug.Log(Spawn);
    }
}