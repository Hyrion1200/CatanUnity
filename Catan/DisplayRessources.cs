using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayRessources : MonoBehaviour
{
        public int wood = 0;
        public int straw = 0;
        public int stone = 0;
        public int sheep = 0;
        public int brick = 0;
        public Text ressourcesText;

    void Update()
    {
        ressourcesText.text = "Bois : " + wood + "\n" + "Brique : " + brick + "\n" + "Mouton : " + sheep + "\n" + "Paille : " + straw + "\n" + "Pierre : " + stone;
    }
}
