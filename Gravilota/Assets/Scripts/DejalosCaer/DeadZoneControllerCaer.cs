﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZoneControllerCaer : MonoBehaviour
{
     // Start is called before the first frame update

    public GameController gameController;
    void Start()
    {
        gameController = GameObject.Find("GlobalScriptsText").GetComponent<GameController>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy (other.gameObject);
        gameController.IncrementScore();
        //AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Capture);
    }
}
