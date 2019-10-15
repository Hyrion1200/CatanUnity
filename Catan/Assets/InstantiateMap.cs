using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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
    public Transform water_map;
    public Transform port_all_map;
    public Transform port_brick_map;
    public Transform port_stone_map;
    public Transform port_wood_map;
    public Transform port_sheep_map;
    public Transform port_straw_map;
    public Transform token_2_map;
    public Transform token_3_map;
    public Transform token_4_map;
    public Transform token_5_map;
    public Transform token_6_map;
    public Transform token_7_map;
    public Transform token_8_map;
    public Transform token_9_map;
    public Transform token_10_map;
    public Transform token_11_map;
    public Transform token_12_map;
    int token_2 = 1;
    int token_3 = 2;
    int token_4 = 2;
    int token_5 = 2;
    int token_6 = 2;
    int token_7 = 1;
    int token_8 = 2;
    int token_9 = 2;
    int token_10 = 2;
    int token_11 = 2;
    int token_12 = 1;
    int water = 9;
    int port_brick = 1;
    int port_wood = 1;
    int port_stone = 1;
    int port_sheep = 1;
    int port_straw = 1;
    int port_all = 4;
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

    public void generator_token(float i, float x, float z, int generator)
    {
        if (generator == 0 & desert > 0 & token_7>0 & i != 2 & i !=4 & i != 15 & i !=18)
        {
            desert--;
            token_7--;
            Instantiate(desert_map, new Vector3(x, 0, z), Quaternion.identity);
            Instantiate(token_7_map, new Vector3(x, 0, z), Quaternion.identity);
            transform.LookAt(Vector3.zero);
            generator_map(i + 1, x, z, aleatoire.Next(6));
        }

        else if (generator == 1 & brick > 0)
        {
            brick--;
            Instantiate(brick_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
        }

        else if (generator == 2 & wood > 0)
        {
            wood--;
            Instantiate(wood_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
        }

        else if (generator == 3 & stone > 0)
        {
            stone--;
            Instantiate(stone_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
        }

        else if (generator == 4 & sheep > 0)
        {
            sheep--;
            Instantiate(sheep_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
        }

        else if (generator == 5 & straw > 0)
        {
            straw--;
            Instantiate(straw_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
        }

        else
        {
            generator_map(i, x, z, aleatoire.Next(6));
        }


           /* if (generator != 0 & i != 2 & i != 4 & i != 15 & i != 18 & random_token == 0 & token_2>0)
            {
                token_2--;
                Instantiate(token_2_map, new Vector3(x, 0, z), Quaternion.identity);
                transform.LookAt(Vector3.zero);
            }
            else if (generator != 0 & i != 2 & i != 4 & i != 15 & i != 18 & random_token == 1 & token_3>0)
            {
                token_3--;
                Instantiate(token_3_map, new Vector3(x, 0, z), Quaternion.identity);
                transform.LookAt(Vector3.zero);
            }
            else if (generator != 0 & i != 2 & i != 4 & i != 15 & i != 18 & random_token == 2 & token_4>0)
            {
                token_4--;
                Instantiate(token_4_map, new Vector3(x, 0, z), Quaternion.identity);
                transform.LookAt(Vector3.zero);
            }

            else if (generator != 0 & i != 2 & i != 4 & i != 15 & i != 18 & random_token == 3 & token_5>0)
            {
                token_5--;
                Instantiate(token_5_map, new Vector3(x, 0, z), Quaternion.identity);
                transform.LookAt(Vector3.zero);
            }
            else if (generator != 0 & i != 2 & i != 4 & i != 15 & i != 18 & random_token == 4 & token_9>0)
            {
                token_9--;
                Instantiate(token_9_map, new Vector3(x, 0, z), Quaternion.identity);
                transform.LookAt(Vector3.zero);
            }
            else if (generator != 0 & i != 2 & i != 4 & i != 15 & i != 18 & random_token == 5 & token_10>0)
            {
                token_10--;
                Instantiate(token_10_map, new Vector3(x, 0, z), Quaternion.identity);
                transform.LookAt(Vector3.zero);
            }
            else if (generator != 0 & i != 2 & i != 4 & i != 15 & i != 18 & random_token == 6 & token_11>0)
            {
                token_11--;
                Instantiate(token_11_map, new Vector3(x, 0, z), Quaternion.identity);
                transform.LookAt(Vector3.zero);
            }
            else if (generator != 0 & i != 2 & i != 4 & i != 15 & i != 18 & random_token == 7 & token_12>0)
            {
                token_12--;
                Instantiate(token_12_map, new Vector3(x, 0, z), Quaternion.identity);
                transform.LookAt(Vector3.zero);
            }
            else
            {

            }*/
        
    }
    public void generator_map(float i, float x, float z, int generator)
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

        };

        if (i == 2 || i == 4)

        {
            Instantiate(token_8_map, new Vector3(x, 0, z), Quaternion.identity);
            transform.LookAt(Vector3.zero);
            generator_token(i, x, z, aleatoire.Next(6));
        }

        else if (i == 15 || i == 18)
        {
            Instantiate(token_6_map, new Vector3(x, 0, z), Quaternion.identity);
            transform.LookAt(Vector3.zero);
            generator_token(i, x, z, aleatoire.Next(6));
        }

        else
        {
            if (i == 20) { }
            else
            {
                generator_token(i, x, z, aleatoire.Next(6));
            }

           
        }
    }
   
    public void generator_sea(float i, float x, float z, int y, int pair, int generator)
    {
        switch (i)
        {
            case 1: x = -1.5f; z = 0; break;
            case 2: x = -1; z = -1; y = -120; break;
            case 3: x = -0.5f; z = -2; break;
            case 4: x = 0; z = -3; y = -120; break;
            case 5: x = 1; z = -3; break;
            case 6: x = 2; z = -3; y = -120; break;
            case 7: x = 3; z = -3; break;
            case 8: x = 3.5f; z = -2; y = 120; break;
            case 9: x = 4; z = -1; break;
            case 10: x = 4.5f; z = 0; y = 120; break;
            case 11: x = 4; z = 1; break;
            case 12: x = 3.5f; z = 2; y = 120; break;
            case 13: x = 3; z = 3; break;
            case 14: x = 2; z = 3; y = 60; break;
            case 15: x = 1; z = 3; break;
            case 16: x = 0; z = 3; y = 0; break;
            case 17: x = -0.5f; z = 2; break;
            case 18: x = -1f; z = 1; y = -60; break;
        }
        if (i == 19) { }
        else if (i < 19)
        {
            if (pair == 1)
            {
                water--;
                Instantiate(water_map, new Vector3(x, 0, z), Quaternion.identity);
                generator_sea(i + 1, x, z, y, pair - 1, aleatoire.Next(6));
            }

            else if (pair == 0)
            {
                if (generator == 0 & port_all > 0)
                {
                    port_all--;
                    Instantiate(port_all_map, new Vector3(x, 0, z), Quaternion.Euler(0, y, 0));
                    generator_sea(i + 1, x, z, y, pair + 1, aleatoire.Next(6));
                }

                else if (generator == 1 & port_brick > 0)
                {
                    port_brick--;
                    Instantiate(port_brick_map, new Vector3(x, 0, z), Quaternion.Euler(0, y, 0));
                    generator_sea(i + 1, x, z, y, pair + 1, aleatoire.Next(6));
                }

                else if (generator == 2 & port_stone > 0)
                {
                    port_stone--;
                    Instantiate(port_stone_map, new Vector3(x, 0, z), Quaternion.Euler(0, y, 0));
                    generator_sea(i + 1, x, z, y, pair + 1, aleatoire.Next(6));
                }

                else if (generator == 3 & port_sheep > 0)
                {
                    port_sheep--;
                    Instantiate(port_sheep_map, new Vector3(x, 0, z), Quaternion.Euler(0, y, 0));
                    generator_sea(i + 1, x, z, y, pair + 1, aleatoire.Next(6));
                }

                else if (generator == 4 & port_straw > 0)
                {
                    port_straw--;
                    Instantiate(port_straw_map, new Vector3(x, 0, z), Quaternion.Euler(0, y, 0));
                    generator_sea(i + 1, x, z, y, pair + 1, aleatoire.Next(6));
                }

                else if (generator == 5 & port_wood > 0)
                {
                    port_wood--;
                    Instantiate(port_wood_map, new Vector3(x, 0, z), Quaternion.Euler(0, y, 0));
                    generator_sea(i + 1, x, z, y, pair + 1, aleatoire.Next(6));
                }

                else
                {
                    generator_sea(i, x, z, y, pair, aleatoire.Next(6));
                }
            }
        }
        else
        {
            generator_sea(i, x, z, y, pair, generator);
        }
    }

    void Start()
    {
        generator_map(1, 0, -2, aleatoire.Next(6));
        generator_sea(1, -1.5f, -3, -120, 1, aleatoire.Next(6));
    }
}