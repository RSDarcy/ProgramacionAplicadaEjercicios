﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class WebServiceClient : MonoBehaviour
{
    // Start is called before the first frame update
    [Serializable]
    public class GravilotaScore
    {
        public int Id;
        public string PlayerName;
        public double Score;
    }
    UnityWebRequest www;
    const string webServiceURL = "https://localhost:44345/api/values";
    void Start()
    {

      //StartCoroutine("SendWebRequest");
        
    }

   public IEnumerator SendWebRequest(double score)
    {
       
       GravilotaScore newScore = new GravilotaScore();
       newScore.Id = 0;
       newScore.PlayerName = "Joha";
       newScore.Score = score;

       //www.UnityWebRequest.Post(webServiceURL, JsonUtility.ToJson(MI_OBJETO));
        www = UnityWebRequest.Put(webServiceURL, JsonUtility.ToJson(newScore));
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();

        Debug.Log(www.downloadHandler.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
