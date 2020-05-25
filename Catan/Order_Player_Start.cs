using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Order_Player_Start : MonoBehaviour
{

    PhotonView PV;
    PhotonView photonView_village;
    Vector3 mousePosition;
    private Vector3 screenPoint;
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        PV = PhotonView.Get(this);
        void lancerdeDés()
        {
            System.Random dé = new System.Random();
            int dé1 = dé.Next(1, 7);
            int dé2 = dé.Next(1, 7);
            int résultat = dé1 + dé2;
            Debug.Log(dé1);
            Debug.Log(dé2);
        }
        void setOrderPlayer(int i)
        {
            if (PV.ViewID == 1001 && i == 1)
            {
                lancerdeDés();
                setOrderPlayer(i + 1);
            }
            else if (PV.ViewID == 2001 && i == 2)
            {
                lancerdeDés();
                setOrderPlayer(i + 1);
            }
            else if (PV.ViewID == 3001 && i == 3)
            {
                lancerdeDés();
                setOrderPlayer(i + 1);
            }
            else if (PV.ViewID == 4001 && i == 4)
            {
                lancerdeDés();
                setOrderPlayer(i + 1);
            }
            else
            {
                Debug.Log("C'est la merde");
            }
        }
        setOrderPlayer(1);
    }
}
