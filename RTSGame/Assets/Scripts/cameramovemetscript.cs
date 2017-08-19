using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovemetscript : MonoBehaviour
{

    


    public float panspeed = 20f;
    public float panspeedsprintbonus = 10f;
    public float scrollspeed = 50f;
    public float rotationspeed = 50f;
    public float panBorderThicknes = 10f;
    public Vector2 panLimit;
    public float minY = 20f;
    public float maxY = 200f;


    void Start()
    {

    }


    void Update()
    {
       Vector3 pos = transform.position;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            panspeed += panspeedsprintbonus;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            panspeed -= panspeedsprintbonus;
        }

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThicknes)
        {
            pos.z += panspeed * Time.deltaTime;
            
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThicknes)
        {
            pos.z -= panspeed * Time.deltaTime;

        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThicknes)
        {
            pos.x += panspeed * Time.deltaTime;

        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThicknes)
        {
            pos.x -= panspeed * Time.deltaTime;

        }
        if (Input.GetMouseButton(3))
        {
          
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollspeed * 100f * Time.deltaTime;
            pos.x = Mathf.Clamp(pos.x, -panLimit.x, panLimit.x);
            pos.y = Mathf.Clamp(pos.y, minY, maxY);
            pos.z = Mathf.Clamp(pos.z, -panLimit.y, panLimit.y);

        transform.position = pos;

        
        
    }
    
}
      

