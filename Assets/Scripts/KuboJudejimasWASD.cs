using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KuboJudejimasWASD : MonoBehaviour {

    public int pagreitejimas;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("w"))
        {
            
            rb.velocity = new Vector3(1, 0, 0);
            rb.MovePosition(transform.position + transform.right * pagreitejimas * Time.deltaTime);

            ////atkodavus: kodas, kuriame judina kuba be pagreicio 
            ////(t.y. nesvarbu, kiek ilgai spaudi klavisa, jega vienoda)
            //transform.Translate(Vector3.right * Time.deltaTime * pagreitejimas, Space.World);
        }
        if(Input.GetKey("a"))
        {
            rb.velocity = new Vector3(0, 0, -1);
            rb.MovePosition(transform.position - transform.forward * pagreitejimas * Time.deltaTime);

            ////atkodavus: kodas, kuriame judina kuba be pagreicio 
            ////(t.y. nesvarbu, kiek ilgai spaudi klavisa, jega vienoda)
            //transform.Translate(Vector3.back * Time.deltaTime * pagreitejimas, Space.World);
        }
        if (Input.GetKey("s"))
        {
            rb.velocity = new Vector3(-1, 0, 0);
            rb.MovePosition(transform.position - transform.right * pagreitejimas * Time.deltaTime);

            ////atkodavus: kodas, kuriame judina kuba be pagreicio 
            ////(t.y. nesvarbu, kiek ilgai spaudi klavisa, jega vienoda)
            //transform.Translate(Vector3.left * Time.deltaTime * pagreitejimas, Space.World);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(0, 0, 1);
            rb.MovePosition(transform.position + transform.forward * pagreitejimas * Time.deltaTime);

            ////atkodavus: kodas, kuriame judina kuba be pagreicio 
            ////(t.y. nesvarbu, kiek ilgai spaudi klavisa, jega vienoda)
            //transform.Translate(Vector3.forward * Time.deltaTime * pagreitejimas, Space.World);
        }
    }
}
