using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int offsetX;
    public int offsetY;
    public int offsetZ;


   void Start()
    {
        Debug.Log("Creating Player");
        GameObject player = PhotonNetwork.Instantiate("Player", new Vector3(1.54f, 5.3f, 0.62f), new Quaternion (0, 0, 0, 0) );
        player.transform.rotation = Quaternion.Euler(90, 0, 0);
        player.GetComponentInChildren<Camera>().enabled = true;
        player.GetComponentInChildren<Camera>().GetComponent<AudioListener>().enabled = true;
    }


    



}
