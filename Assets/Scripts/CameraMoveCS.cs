using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveCS : MonoBehaviour
{
    public float speed;
    void MoveRight()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey("w")) ;
        {
            MoveRight();
        }
    }

   
}
