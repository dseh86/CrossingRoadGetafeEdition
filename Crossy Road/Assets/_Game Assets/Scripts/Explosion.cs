using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {


    [SerializeField] AudioSource asExplosion;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {

         asExplosion = GetComponent<AudioSource>();

        asExplosion.Play();
    }
}
