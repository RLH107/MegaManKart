using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KartSelect : MonoBehaviour
{
    public RotateOnAxis rot;
    public GameObject Kart;
    public static GameObject SelectedKart;
    //quando o mouse passar em cima 
    private void OnMouseOver()
    {
        rot.enabled = true;
    }
    //quando o mouse sair
    private void OnMouseExit()
    {
        rot.enabled = false;
    }

    //quando clicar em cima
    private void OnMouseDown()
    {
        //carrega proxima cena 
        SceneManager.LoadScene("MainScene");

        //guarda o prefab do carrinho em uma variavel estatica q persiste entre os levels 
        SelectedKart = Kart;
    }
}
