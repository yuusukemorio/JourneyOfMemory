using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public float sensitivity = 0.1f;
    float mouse_x;
    float matome = 0; 

    //float mouse_y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouse_x = Input.GetAxis("Mouse X") * sensitivity;
        //mouse_y = Input.GetAxis("Mouse y") * sensitivity;



        Debug.Log(mouse_x);
        //Debug.Log(mouse_y);
    }
}
