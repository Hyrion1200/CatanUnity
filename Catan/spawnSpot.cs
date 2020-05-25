using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSpot : MonoBehaviour
{
    public Transform spot;
    public Transform colony;
    
    void Start()
    {
        Instantiate(spot, new Vector3(0, 0.1f, 2.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(0.5f, 0.1f, 2.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(1, 0.1f, 2.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(1.5f, 0.1f, 2.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(2, 0.1f, 2.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(2.5f, 0.1f, 2.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(3, 0.1f, 2.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(-0.5f, 0.1f, 1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(0, 0.1f, 1.55f), Quaternion.identity);
        Instantiate(spot, new Vector3(0.5f, 0.1f, 1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(1, 0.1f, 1.55f), Quaternion.identity);
        Instantiate(spot, new Vector3(1.5f, 0.1f, 1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(2, 0.1f, 1.55f), Quaternion.identity);
        Instantiate(spot, new Vector3(2.5f, 0.1f, 1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(3, 0.1f, 1.55f), Quaternion.identity);
        Instantiate(spot, new Vector3(3.5f, 0.1f, 1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(-1, 0.1f, 0.4f), Quaternion.identity);
        Instantiate(spot, new Vector3(-0.5f, 0.1f, 0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(0, 0.1f, 0.4f), Quaternion.identity);
        Instantiate(spot, new Vector3(0.5f, 0.1f, 0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(1, 0.1f, 0.4f), Quaternion.identity);
        Instantiate(spot, new Vector3(1.5f, 0.1f, 0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(2, 0.1f, 0.4f), Quaternion.identity);
        Instantiate(spot, new Vector3(2.5f, 0.1f, 0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(3, 0.1f, 0.4f), Quaternion.identity);
        Instantiate(spot, new Vector3(3.5f, 0.1f, 0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(4, 0.1f, 0.4f), Quaternion.identity);
        Instantiate(spot, new Vector3(-1, 0.1f, -0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(-0.5f, 0.1f, -0.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(0, 0.1f, -0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(0.5f, 0.1f, -0.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(1, 0.1f, -0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(1.5f, 0.1f, -0.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(2, 0.1f, -0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(2.5f, 0.1f, -0.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(3, 0.1f, -0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(3.5f, 0.1f, -0.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(4, 0.1f, -0.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(-0.5f, 0.1f, -1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(0, 0.1f, -1.55f), Quaternion.identity);
        Instantiate(spot, new Vector3(0.5f, 0.1f, -1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(1, 0.1f, -1.55f), Quaternion.identity);
        Instantiate(spot, new Vector3(1.5f, 0.1f, -1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(2, 0.1f, -1.55f), Quaternion.identity);
        Instantiate(spot, new Vector3(2.5f, 0.1f, -1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(3, 0.1f, -1.55f), Quaternion.identity);
        Instantiate(spot, new Vector3(3.5f, 0.1f, -1.45f), Quaternion.identity);
        Instantiate(spot, new Vector3(0, 0.1f, -2.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(0.5f, 0.1f, -2.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(1, 0.1f, -2.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(1.5f, 0.1f, -2.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(2, 0.1f, -2.5f), Quaternion.identity);
        Instantiate(spot, new Vector3(2.5f, 0.1f, -2.6f), Quaternion.identity);
        Instantiate(spot, new Vector3(3, 0.1f, -2.5f), Quaternion.identity);
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.transform != null)
                {
                    Destroy(hit.transform.gameObject);
                    spawn(hit.transform.gameObject);
                }
            }
        }
    }

    

    void DestroyGameObject()
    {
        Destroy(spot);
    }

    void spawn(GameObject spot)
    {
        Instantiate(colony,new Vector3(3, 0.1f, -2.5f), Quaternion.identity);
    }
    // Update is called once per frames
}
