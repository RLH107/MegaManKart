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
        GameObject car = Instantiate(KartSelect.SelectedKart, transform.position, transform.rotation);
        //aponta a camera pro carro
        cameraC.Follow = car.transform;
        cameraC.LookAt = car.transform;

    }
}
