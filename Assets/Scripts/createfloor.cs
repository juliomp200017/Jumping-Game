using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createfloor : MonoBehaviour
{
    public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("create_floor", 0, 3);
    }

    // Update is called once per frame
    void create_floor()
    {
        Instantiate(floor, transform.position, Quaternion.identity);
    }
}
