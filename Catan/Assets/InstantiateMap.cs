using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstantiateMap : MonoBehaviour
{
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
    int desert_case = 1;
    int brick_case = 2;
    int wood_case = 3;
    int stone_case = 4;
    int sheep_case = 5;
    int straw_case = 6;
    int token_2 = 1;
    int token_3 = 2;
    int token_4 = 2;
    int token_5 = 2;
    int token_9 = 2;
    int token_10 = 2;
    int token_11 = 2;
    int token_12 = 1;
    int token_2_case = 2;
    int token_3_case = 3;
    int token_4_case = 4;
    int token_5_case = 5;
    int token_6_case = 6;
    int token_7_case = 7;
    int token_8_case = 8;
    int token_9_case = 9;
    int token_10_case = 10;
    int token_11_case = 11;
    int token_12_case = 12;

    int[,] bigOne = new int[20, 20];

    int[,] babyOne = new int[20, 20];

    [SerializeField]
    private GameObject RollButton;

    Transform tk;
    System.Random aleatoire = new System.Random();
    System.Random random = new System.Random();

    

    public void generator_token(int i, float x, float z, ref int token_2, ref int token_3, ref int token_4, ref int token_5, ref int token_9, ref int token_10, ref int token_11, ref int token_12)
    {
        int token = token = random.Next(2, 13);
        switch (token)
        {
            case 2: tk = token_2_map; break;
            case 3: tk = token_3_map; break;
            case 4: tk = token_4_map; break;
            case 5: tk = token_5_map; break;
            case 9: tk = token_9_map; break;
            case 10: tk = token_10_map; break;
            case 11: tk = token_11_map; break;
            case 12: tk = token_12_map; break;
        };
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
        if (i > 19) { }
        else if (i == 1 || i == 5 || i == 6 || i == 7 || i == 8 || i == 9 || i == 10 || i == 11 || i == 12 || i == 13 || i == 14 || i == 16 || i == 17 || i == 19)
        {


            if (token == 2 && token_2 > 0)
            {
                token_2--;
                babyOne[0, i] = token_2_case;
                Instantiate(tk, new Vector3(x, 0, z), Quaternion.identity);
                generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            }
            else if (token == 3 && token_3 > 0)
            {
                token_3--;
                babyOne[0, i] = token_3_case;
                Instantiate(tk, new Vector3(x, 0, z), Quaternion.identity);
                generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            }
            else if (token == 4 && token_4 > 0)
            {
                token_4--;
                babyOne[0, i] = token_4_case;
                Instantiate(tk, new Vector3(x, 0, z), Quaternion.identity);
                generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            }
            else if (token == 5 && token_5 > 0)
            {
                token_5--;
                babyOne[0, i] = token_5_case;
                Instantiate(tk, new Vector3(x, 0, z), Quaternion.identity);
                generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            }
            else if (token == 9 && token_9 > 0)
            {
                token_9--;
                babyOne[0, i] = token_9_case;
                Instantiate(tk, new Vector3(x, 0, z), Quaternion.identity);
                generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            }
            else if (token == 10 && token_10 > 0)
            {
                token_10--;
                babyOne[0, i] = token_10_case;
                Instantiate(tk, new Vector3(x, 0, z), Quaternion.identity);
                generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            }
            else if (token == 11 && token_11 > 0)
            {
                token_11--;
                babyOne[0, i] = token_11_case;
                Instantiate(tk, new Vector3(x, 0, z), Quaternion.identity);
                generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            }
            else if (token == 12 && token_12 > 0)
            {
                token_12--;
                babyOne[0, i] = token_12_case;
                Instantiate(tk, new Vector3(x, 0, z), Quaternion.identity);
                generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            }
            else { generator_token(i, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12); }
        }
        else if (i == 2 || i == 4)
        {
            Instantiate(token_8_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            babyOne[0, i] = token_8_case;
        }
        else if (i == 15 || i == 18)
        {
            Instantiate(token_6_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            babyOne[0, i] = token_6_case;
        }
        else if (i == 3)
        {
            Instantiate(token_7_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_token(i + 1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
            babyOne[0, i] = token_7_case;
        }

        else
        {
            Debug.Log("Fin Token");
        }
    }

    public void generator_map(int i, float x, float z, int generator)
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
        if (i == 3)
        {
            Instantiate(desert_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
            bigOne[0, i] = desert_case;
        }

        else if (generator == 1 & brick > 0)
        {
            brick--;
            Instantiate(brick_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
            bigOne[0, i] = brick_case;
        }

        else if (generator == 2 & wood > 0)
        {
            wood--;
            Instantiate(wood_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
            bigOne[0, i] = wood_case;
        }

        else if (generator == 3 & stone > 0)
        {
            stone--;
            Instantiate(stone_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
            bigOne[0, i] = stone_case;
        }

        else if (generator == 4 & sheep > 0)
        {
            sheep--;
            Instantiate(sheep_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
            bigOne[0, i] = sheep_case;

        }

        else if (generator == 5 & straw > 0)
        {
            straw--;
            Instantiate(straw_map, new Vector3(x, 0, z), Quaternion.identity);
            generator_map(i + 1, x, z, aleatoire.Next(6));
            bigOne[0, i] = straw_case;
        }


        else if (i > 19) { Debug.Log("Fin Map"); }
        else
        {
            generator_map(i, x, z, aleatoire.Next(6));
        }

    }

    public void generator_sea(int i, float x, float z, int y, int pair, int generator)
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

    public void lancerdeDés()
    {
        roll(wood, stone, straw, brick , sheep); 
    }
    public void roll(int wood, int stone , int straw, int brick , int sheep)
    {
        DisplayRessources ressources;
        ressources = FindObjectOfType<DisplayRessources>();
        System.Random dé = new System.Random();
        int dé1 = dé.Next(1, 7);
        int dé2 = dé.Next(1, 7);
        int resultat = dé1 + dé2;
        Debug.Log("Ton dé a fait : " + resultat);
        int m = babyOne.GetLength(0);
        int n = babyOne.GetLength(1);
        int valeur_ressource = 0;
        
        for (int a = 0; a < m; a++)
        {
            for (int b = 0; b < n; b++)
            {
                if (babyOne[a, b] == resultat)
                {
                    valeur_ressource = bigOne[a, b];
                    if (valeur_ressource == 1)
                    {
                    }
                    else if (valeur_ressource == 2)
                    {
                        ressources.brick++;
                        Debug.Log("Bois : " + wood + ", " + "Pierre : " + stone + ", " + "Paille : " + straw + ", " + "Mouton : " + sheep + ", " + "Brique : " + brick);
                    }
                    else if (valeur_ressource == 3)
                    {
                        ressources.wood++;
                        Debug.Log("Bois : " + wood + ", " + "Pierre : " + stone + ", " + "Paille : " + straw + ", " + "Mouton : " + sheep + ", " + "Brique : " + brick);
                    }
                    else if (valeur_ressource == 4)
                    {
                        ressources.stone++;
                        Debug.Log("Bois : " + wood + ", " + "Pierre : " + stone + ", " + "Paille : " + straw + ", " + "Mouton : " + sheep + ", " + "Brique : " + brick);
                    }
                    else if (valeur_ressource == 5)
                    {
                        ressources.sheep++;
                        Debug.Log("Bois : " + wood + ", " + "Pierre : " + stone + ", " + "Paille : " + straw + ", " + "Mouton : " + sheep + ", " + "Brique : " + brick);
                    }
                    else if (valeur_ressource == 6)
                    {
                        ressources.straw++;
                        Debug.Log("Bois : " + wood + ", " + "Pierre : " + stone + ", " + "Paille : " + straw + ", " + "Mouton : " + sheep + ", " + "Brique : " + brick);
                    }
                    else
                    {
                    }
                }
                else { }
                   
            }
        }
    }

    
    
    void Start()
    {
      generator_token(1, 0, 0, ref token_2, ref token_3, ref token_4, ref token_5, ref token_9, ref token_10, ref token_11, ref token_12);
      generator_map(1, 0, -2, aleatoire.Next(6));
      generator_sea(1, -1.5f, -3, -120, 1, aleatoire.Next(6));
    }
}
