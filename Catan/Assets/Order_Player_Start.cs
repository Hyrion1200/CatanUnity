using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Order_Player_Start : MonoBehaviour
{
    
    PhotonView Pv;
    PhotonView photonView_village;
    public GameObject Village_r1;
    public GameObject Route_r1;
    Vector3 mousePosition;



        // Start is called before the first frame update
        void Start()
    {
        Pv = PhotonView.Get(this);
        PhotonNetwork.Instantiate("Village", Vector3.zero, Quaternion.identity);
        PhotonNetwork.Instantiate("RoadEnd", Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
        mousePosition = new Vector3(mousePosition.x, mousePosition.y, 2);
        Village_r1.transform.position = mousePosition;

   
    }
}
