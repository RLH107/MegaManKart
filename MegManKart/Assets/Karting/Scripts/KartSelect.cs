using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KartSelect : MonoBehaviour
{
    public RotateOnAxis rot;
    public GameObject Kart1, Kart2;
    public static GameObject SelectedKart1, SelectedKart2;

    private static bool kart1WasChosen;

    private void Start()
    {
        kart1WasChosen = false;
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
        if (kart1WasChosen)
        {
            SceneManager.LoadScene("MainScene");

            SelectedKart2 = Kart2;
        }
        else
        {
            SelectedKart1 = Kart1;
            kart1WasChosen = true;
        }
    }
}
