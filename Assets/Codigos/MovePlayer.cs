using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Vel = 5;
    public float Rot = 5;
    private float x, y;
    public Rigidbody rb;
    public Animator Anim;

    public float FSalto = 8;
    public bool PuedeSalatar ;


    private void Start()
    {
        PuedeSalatar = false;

    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * Rot, 0);
        transform.Translate(0, 0, y * Time.deltaTime * Vel);

    }


    void Update()
    {
         x = Input.GetAxis("Horizontal");

         y = Input.GetAxis("Vertical");

        
        Anim.SetFloat("Velx", x);
        Anim.SetFloat("Vely", y);


        if (PuedeSalatar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Anim.SetBool("Salto", true);
                rb.AddForce(new Vector3(0, FSalto, 0), ForceMode.Impulse);
            }
            Anim.SetBool("TocarSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }

    }

    public void EstoyCayendo()
    {
        Anim.SetBool("Salto", false);
        Anim.SetBool("TocarSuelo", false);
    }
}
