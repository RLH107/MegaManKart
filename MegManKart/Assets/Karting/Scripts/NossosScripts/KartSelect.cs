using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KartSelect : MonoBehaviour
{
    public RotateOnAxis rot;
    public GameObject kart;
    public static GameObject player1Kart, player2Kart;

    //public GameObject player1KartSelect1, player1KartSelect2, player1KartSelect3, player1KartSelect4;
    //public GameObject player2KartSelect1, player2KartSelect2, player2KartSelect3, player2KartSelect4;

    public static bool firstKartChosen;

    private void Start()
    {
        firstKartChosen = false;    
    }

    private void OnMouseOver()
    {
        rot.enabled = true;
    }

    private void OnMouseExit()
    {
        rot.enabled = false;
    }

    //quando clicar em cima
    private void OnMouseDown()
    {
        if (firstKartChosen)
        {
            SceneManager.LoadScene("MainScene");

            /*
            player2KartSelect1.SetActive(true);
            player2KartSelect2.SetActive(true);
            player2KartSelect3.SetActive(true);
            player2KartSelect4.SetActive(true);

            player1KartSelect1.SetActive(false);
            player1KartSelect2.SetActive(false);
            player1KartSelect3.SetActive(false);
            player1KartSelect4.SetActive(false);
            */

            player2Kart = kart;

            kart.GetComponent<ArcadeKart>().isPlayerOne = false;
        }
        else
        {
            firstKartChosen = true;

            player1Kart = kart;

            kart.GetComponent<ArcadeKart>().isPlayerOne = true;
        }
    }
}
