﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InstantiateMap : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform prefab;

    int desert = 1;
    int brick = 3;
    int wood = 4;
    int stone = 3;
    int sheep = 4;
    int straw = 4;
    int x = -3;
    int z = -3;
    int i = 0;
    int pair = 0;
    void generator_map(int i, int x, int z, int pair)
    {

            System.Random aleatoire = new System.Random();
            int generator = aleatoire.Next(6);
            if(i = 20) { }
            else if (generator == 0 & desert > 0)
            {
                desert--;
                Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
            if (pair = 1)
            {
                generator_map(i + 1, x + 1, z, pair - 1);
            }
            else
            {
                generator_map(i + 1, x, z + 1, pair + 1);
            }
            }

            else if (generator == 1 & brick > 0)
            {
                brick--;
                Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
            if (pair = 1)
            {
                generator_map(i + 1, x + 1, z, pair - 1);
            }
            else
            {
                generator_map(i + 1, x, z + 1, pair + 1);
            }
        }

            else if (generator == 2 & wood > 0)
            {
                wood--;
                Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
            if (pair = 1)
            {
                generator_map(i + 1, x + 1, z, pair - 1);
            }
            else
            {
                generator_map(i + 1, x, z + 1, pair + 1);
            }
        }

            else if (generator == 3 & stone > 0)
            {
                stone--;
                Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
            if (pair = 1)
            {
                generator_map(i + 1, x + 1, z, pair - 1);
            }
            else
            {
                generator_map(i + 1, x, z + 1, pair + 1);
            }
        }

            else if (generator == 4 & sheep > 0)
            {
                sheep--;
                Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
            if (pair = 1)
            {
                generator_map(i + 1, x + 1, z, pair - 1);
            }
            else
            {
                generator_map(i + 1, x, z + 1, pair + 1);
            }
        }

            else if (generator == 5 & straw > 0)
            {
                straw--;
                Instantiate(prefab, new Vector3(x, 0, z), Quaternion.identity);
            if (pair = 1)
            {
                generator_map(i + 1, x + 1, z, pair - 1);
            }
            else
            {
                generator_map(i + 1, x, z + 1, pair + 1);
            }
        }


        }
        void Start()
        {
            generator_map(0, -3, -3, 0);
        }
    
}
