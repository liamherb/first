using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float force = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 planePos = new Vector3(0, transform.position.y, 0);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, planePos);
        float rayLength;

        if(groundPlane.Raycast(ray, out rayLength))
        {
            
            Vector3 pointToLook = ray.GetPoint(rayLength);
            transform.LookAt(pointToLook);
        }
        float x = Input.GetAxis("Horizontal") * force;
        float z = Input.GetAxis("Vertical") * force;
        transform.Translate(x, 0, z);
        Rigidbody rb = GetComponent<Rigidbody>();
    }
}
