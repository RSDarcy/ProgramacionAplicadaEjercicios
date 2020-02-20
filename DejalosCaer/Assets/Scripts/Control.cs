using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
    public float velocidadX = 0.1f;
    private Vector3 translate;
    private const float limiI = -2.6f;
    private const float LimiD = 2.6f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        translate = new Vector3(Input.GetAxis("Horizontal") * velocidadX ,0);
        gameObject.transform.Translate(translate);

        gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, limiI, LimiD), gameObject.transform.position.y, gameObject.transform.position.z);
	}
}
