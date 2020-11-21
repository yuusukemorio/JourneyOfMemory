using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idou : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed,0,0);
        if (this.transform.position.x >= 300)
        {
            this.transform.position = new Vector3(-20.9f,6, 15f);
        }
    }
}
