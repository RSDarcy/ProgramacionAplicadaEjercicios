using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGlobal : MonoBehaviour {
    public GameObject CuboPrefab;
    private Vector3 nuevaPos;
    private const float limiI = -2.6f;
    private const float limiD = 2.6f;
    private float periodoInstancia = 1f;
	// Use this for initialization
	void Start () {
        InvokeRepeating("InstanciarCubo", 0f, periodoInstancia);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void InstanciarCubo()
    {
        nuevaPos = new Vector3(Random.Range(limiI, limiD), 6f);
        Instantiate(CuboPrefab, nuevaPos, Quaternion.identity);
    }
}
