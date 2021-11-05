using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galletas : MonoBehaviour
{
    NumGalletas numGalletas;

    void Start()
    {
        numGalletas = GameObject.FindGameObjectWithTag("Player").GetComponent<NumGalletas>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            numGalletas.NumG = numGalletas.NumG + 1;
            Destroy(gameObject);
        }
       
    }
}
