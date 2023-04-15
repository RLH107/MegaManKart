using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartCreator : MonoBehaviour
{
    public CinemachineVirtualCamera player1Cam, player2Cam;
    public Transform player1SpawnPoint, player2SpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        //cria o carrinho na cena 
        GameObject firstKart = Instantiate(KartSelect.player1Kart, player1SpawnPoint.position, player1SpawnPoint.rotation);
        GameObject secondKart = Instantiate(KartSelect.player2Kart, player2SpawnPoint.position, player2SpawnPoint.rotation);
        //aponta a camera pro carro
        player1Cam.Follow = firstKart.transform;
        player1Cam.LookAt = firstKart.transform;
        player2Cam.Follow = secondKart.transform;
        player2Cam.LookAt = secondKart.transform;

    }
}
