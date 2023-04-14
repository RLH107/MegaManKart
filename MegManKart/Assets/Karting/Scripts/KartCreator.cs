using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartCreator : MonoBehaviour
{
    public CinemachineVirtualCamera cameraC;
    // Start is called before the first frame update
    void Start()
    {
        //cria o carrinho na cena 
        GameObject car1 = Instantiate(KartSelect.SelectedKart1, transform.position, transform.rotation);
        //aponta a camera pro carro
        cameraC.Follow = car1.transform;
        cameraC.LookAt = car1.transform;

        //cria o carrinho na cena 
        GameObject car2 = Instantiate(KartSelect.SelectedKart2, transform.position, transform.rotation);
        //aponta a camera pro carro
        cameraC.Follow = car2.transform;
        cameraC.LookAt = car2.transform;

    }
}
