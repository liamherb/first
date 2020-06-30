using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ThrowGrenade : MonoBehaviour
{
    public GameObject grenade;
    public Transform throwPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(grenade, throwPoint.position, Quaternion.identity);
        }
    }
}
