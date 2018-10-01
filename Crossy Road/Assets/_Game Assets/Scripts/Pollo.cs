using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pollo : MonoBehaviour {

    private Rigidbody rb;
    private Transform tf;

    [SerializeField] int fuerza = 10;
    [SerializeField] Transform posPies;
	void Start () {

        //Recogemos la referencia 
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {
        //salto
        if (Input.GetKeyDown("space")) 
        {
            /*int layerMaskIndex = LayerMask.NameToLayer("Terrain");
            Collider [] cols =Physics.OverlapSphere(posPies.position, 10f, layerMaskIndex);
            for (int i = 0; i < cols.Length; i++)
            {
                                Debug.Log("You touch my tralala, my ding, ding " + i);
            }*/
            rb.AddForce(new Vector3 (0,1,0) * fuerza);
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

        if(Input.GetKeyDown("right"))
        {
            rb.AddForce(new Vector3(1, 0, 0) * fuerza);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("naziStuff");
        Destroy(other.gameObject);



    }
}
