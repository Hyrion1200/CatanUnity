using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InstantiateMap : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform prefab;
    void Start()
    {   
        int desert = 1;
        int brick = 3;
        int wood = 4;
        int stone = 3;
        int sheep = 4;
        int straw = 4;
        int x;
        int z;
        void generator_map()
        {

            int i = 0;
            while (i <= 19)
            {
                if (i == 1)
                {
                    x = 0;
                    z = 0;
                }

                if (i == 2)
                {
                    x = 1;
                    z = 0;
                }

                if (i == 3)
                {
                    x = 2;
                    z = 0;
                }

                if (i == 4)
                {
                    x = 3;
                    z = 0;
                }

                if (i == 5)
                {
                    x = 4;
                    z = 0;
                }

                if (i == 5)
                {
                    x = 4;
                    z = 0;
                }

                if (i == 6)
                {
                    x = 0;
                    z = 1;
                }

                if (i == 7)
                {
                    x = 1;
                    z = 1;
                }

                if (i == 8)
                {
                    x = 2;
                    z = 1;
                }

                if (i == 9)
                {
                    x = 3;
                    z = 1;
                }

                if (i == 10)
                {
                    x = 0;
                    z = -1;
                }

                if (i == 11)
                {
                    x = 1;
                    z = -1;
                }

                if (i == 12)
                {
                    x = 2;
                    z = -1;
                }

                if (i == 13)
                {
                    x = 3;
                    z = -1;
                }

                if (i == 14)
                {
                    x = 0;
                    z = 2;
                }

                if (i == 15)
                {
                    x = 1;
                    z = 2;
                }

                if (i == 16)
                {
                    x = 2;
                    z = 2;
                }

                if (i == 17)
                {
                    x = 0;
                    z = -2;
                }

                if (i == 18)
                {
                    x = 1;
                    z = -2;
                }

                if (i == 19)
                {
                    x = 2;
                    z = -2;
                }

                System.Random aleatoire = new System.Random();
                int generator = aleatoire.Next(6);

                if (generator == 0 & desert > 0)
                {
                    desert--;
                    Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
                }

                if (generator == 1 & brick > 0)
                {
                    brick--;
                    Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
                }

                if (generator == 2 & wood > 0)
                {
                    wood--;
                    Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
                }

                if (generator == 3 & stone > 0)
                {
                    stone--;
                    Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
                }

                if (generator == 4 & sheep > 0)
                {
                    sheep--;
                    Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
                }

                if (generator == 5 & straw > 0)
                {
                    straw--;
                    Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
                }

                
                else
                {
                    generator_map();
                }
                i++;
            };
        }
    }
}