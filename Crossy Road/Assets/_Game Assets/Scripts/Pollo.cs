using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollo : MonoBehaviour {

    private Rigidbody rb;
    private Transform tf;

    [SerializeField] int fuerza = 10;
    [SerializeField] Transform posPies;
    [SerializeField] int distanciaDeteccion = 10;
    void Start() {

        //Recogemos la referencia 
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update() {
        //salto
        if (Input.GetKeyDown("space"))
        {

            rb.AddForce(new Vector3(0, 1, 0.5F) * fuerza);
        }
        if (Input.GetKeyDown("up"))
        {
            rb.AddForce(new Vector3(0, 0, 1) * fuerza);
        }

        if (Input.GetKeyDown("down"))
        {
            rb.AddForce(new Vector3(0, 0, -1) * fuerza);
        }
        if (Input.GetKeyDown("left"))
        {
            rb.AddForce(new Vector3(-1, 0, 0) * fuerza);
        }

        if (Input.GetKeyDown("right"))
        {
            rb.AddForce(new Vector3(1, 0, 0) * fuerza);
        }


    }


    private bool EstoyEnSuelo()
    {
        int layerIndex = LayerMask.NameToLayer("Terrain");
        bool enSuelo = false;

        enSuelo = Physics.CheckSphere(posPies.position, distanciaDeteccion, layerIndex);


        /* Collider [] cols =Physics.OverlapSphere(posPies.position, 10f, layerIndex);
         for (int i = 0; i < cols.Length; i++)
         {
                             Debug.Log("You touch my tralala, my ding, ding " + i);
         }*/

        return enSuelo;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("naziStuff");
        Destroy(other.gameObject);



    }
}
