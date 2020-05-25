using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    // Start is called before the first frame update
    void lancerdeDés()
    {
        System.Random dé = new System.Random();
        int dé1 = dé.Next(1, 7);
        int dé2 = dé.Next(1, 7);
        int résultat = dé1 + dé2;
    }
    void Start()
    {


        lancerdeDés();

    }

}
