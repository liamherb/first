using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float countDown = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward);
        if(countDown <= 0)
        {
            Explode();
        }
        else
        {
            countDown -= Time.deltaTime;
        }
    }
    public void Explode()
    {
        Destroy(gameObject);
    }
}
