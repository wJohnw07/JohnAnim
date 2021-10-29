using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pies : MonoBehaviour
{
    public MovePlayer moveplayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        moveplayer.PuedeSalatar = true;

    }
    private void OnTriggerExit(Collider other)
    {
        moveplayer.PuedeSalatar = false;

    }
}
