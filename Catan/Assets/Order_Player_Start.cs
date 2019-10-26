using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Order_Player_Start : MonoBehaviour
{
    
    PhotonView Pv;
    PhotonView photonView_village;
    public Transform Village_r1;
    public Transform Route_r1;
    Vector3 mousePosition;
    private Vector3 screenPoint;
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        Pv = PhotonView.Get(this);
        
    }
   
    // Update is called once per frame
    void Update()
    {
       // cubeRenderer.material.SetColor("_Color", Color.red);


    }
}
