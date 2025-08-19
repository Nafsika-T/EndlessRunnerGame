using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleWin : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == thePlayer)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = false;
            levelControl.GetComponent<Win>().StartWinSequence(); // Ξεκινά την ακολουθία νίκης
        }
    }
}
