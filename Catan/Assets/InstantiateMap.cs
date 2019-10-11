using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InstantiateMap : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform brick_map;
    public Transform desert_map;
    public Transform wood_map;
    public Transform stone_map;
    public Transform sheep_map;
    public Transform straw_map;
    int desert = 1;
    int brick = 3;
    int wood = 4;
    int stone = 3;
    int sheep = 4;
    int straw = 4;
    int x = 0;
    int z = -2;
    int i = 0;
    int pair = 0;
    System.Random aleatoire = new System.Random();
  
    void generator_map(float i, float x, float z, int pair, int generator)
    {
        switch (i)
        {
            case 1: x = -0.5f; z = 0; break;
            case 2: x = 0.5f; z = 0; break;
            case 3: x = 1.5f; z = 0; break;
            case 4: x = 2.5f; z = 0; break;
            case 5: x = 3.5f; z = 0; break;
            case 6: x = 0; z = 1; break;
            case 7: x = 1; z = 1; break;
            case 8: x = 2; z = 1; break;
            case 9: x = 3; z = 1; break;
            case 10: x = 0; z = -1; break;
            case 11: x = 1; z = -1; break;
            case 12: x = 2; z = -1; break;
            case 13: x = 3; z = -1; break;
            case 14: x = 0.5f; z = 2; break;
            case 15: x = 1.5f; z = 2; break;
            case 16: x = 2.5f; z = 2; break;
            case 17: x = 0.5f; z = -2; break;
            case 18: x = 1.5f; z = -2; break;
            case 19: x = 2.5f; z = -2; break;

        }
            
             
        if (i == 20) { }
        else if (generator == 0 & desert > 0)
        {
            desert--;
            Instantiate(desert_map, new Vector3(x, 0, z), Quaternion.identity);
            if (pair == 1)
            {
                generator_map(i + 1, x, z, pair - 1, aleatoire.Next(6));
            }
            else
            {
                generator_map(i + 1, x, z, pair + 1, aleatoire.Next(6));
            }
        }

        else if (generator == 1 & brick > 0)
        {
            brick--;
            Instantiate(brick_map, new Vector3(x, 0, z), Quaternion.identity);
            if (pair == 1)
            {
                generator_map(i + 1, x, z, pair - 1, aleatoire.Next(6));
            }
            else
            {
                generator_map(i + 1, x, z, pair + 1, aleatoire.Next(6));
            }
        }
        else if (generator == 2 & wood > 0)
        {
            wood--;
            Instantiate(wood_map, new Vector3(x, 0, z), Quaternion.identity);
            if (pair == 1)
            {
                generator_map(i + 1, x, z, pair - 1, aleatoire.Next(6));
            }
            else
            {
                generator_map(i + 1, x, z, pair + 1, aleatoire.Next(6));
            }
        }

        else if (generator == 3 & stone > 0)
        {
            stone--;
            Instantiate(stone_map, new Vector3(x, 0, z), Quaternion.identity);
            if (pair == 1)
            {
                generator_map(i + 1, x, z, pair - 1, aleatoire.Next(6));
            }
            else
            {
                generator_map(i + 1, x, z, pair + 1, aleatoire.Next(6));
            }
        }

        else if (generator == 4 & sheep > 0)
        {
            sheep--;
            Instantiate(sheep_map, new Vector3(x, 0, z), Quaternion.identity);
            if (pair == 1)
            {
                generator_map(i + 1, x, z, pair - 1, aleatoire.Next(6));
            }
            else
            {
                generator_map(i + 1, x, z, pair + 1, aleatoire.Next(6));
            }
        }

        else if (generator == 5 & straw > 0)
        {
            straw--;
            Instantiate(straw_map, new Vector3(x, 0, z), Quaternion.identity);
            if (pair == 1)
            {
                generator_map(i + 1, x, z, pair - 1, aleatoire.Next(6));
            }
            else
            {
                generator_map(i + 1, x, z, pair + 1, aleatoire.Next(6));
            }
        }
        else
        {
            generator_map(i, x, z, pair, aleatoire.Next(6));
        }
    }
    void Start()
    {
        generator_map(1, 0, -2, 0, aleatoire.Next(6));
    }



}