using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform projectile;
    public int offsetX;
    public int offsetY;
    public int offsetZ;


   void Start()
    {
        Debug.Log("Creating Player");
        GameObject player = PhotonNetwork.Instantiate("Player", new Vector3(0, 5, 0), new Quaternion(30,0,0,0));
        player.GetComponentInChildren<Camera>().enabled = true;
        player.GetComponentInChildren<Camera>().GetComponent<AudioListener>().enabled = true;
    }
    



}
