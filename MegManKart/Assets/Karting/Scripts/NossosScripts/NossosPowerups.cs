using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NossosPowerups : MonoBehaviour
{
    private float randNum = 0;

    public GameObject forceField;

    private bool canUseForceField, canUseBearTrap, canUseZeroBlades, canUseCards, canUseElectricWeb;
    private bool hasUsedForceField;

    private float forceFieldTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        canUseForceField = false;
        canUseBearTrap = false; 
        canUseZeroBlades = false;   
        canUseCards = false;    
        canUseElectricWeb = false;  

        hasUsedForceField = false;  
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LootBox") && !canUseBearTrap && !canUseCards && !canUseElectricWeb && !canUseForceField && !canUseZeroBlades)
        {
            randNum = Random.Range(1, 6);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (randNum == 1)
        {
            canUseForceField = true;
            Debug.Log("ForceField");
        }
        if (randNum == 2)
        {
            canUseBearTrap = true;
            Debug.Log("BearTrap");
        }
        if (randNum == 3)
        {
            canUseZeroBlades = true;
            Debug.Log("ZeroBlades");
        }
        if (randNum == 4)
        {
            canUseElectricWeb = true;
            Debug.Log("ElectricWeb");
        }
        if (randNum == 5)
        {
            canUseCards = true;
            Debug.Log("Cards");
        }

        if(hasUsedForceField)
        {
            forceFieldTimer -= Time.deltaTime;

            if (forceFieldTimer <= 0)
            {
                forceField.SetActive(false);
                hasUsedForceField = false;
            }
        }
    }

    private void OnMouseDown()
    {
        if (canUseElectricWeb)
        {
            Debug.Log("UsedElectricWeb");
            //Instanciar Orbe
            canUseElectricWeb = false;
            randNum = 0;
        }
        if (canUseBearTrap)
        {
            Debug.Log("UsedBearTrap");
            //Instanciar BearTrap
            canUseBearTrap = false;
            randNum = 0;
        }
        if (canUseCards)
        {
            Debug.Log("UsedCards");
            //Instanciar Cards
            canUseCards = false;
            randNum = 0;
        }
        if (canUseForceField)
        {
            Debug.Log("UsedForceField");
            forceField.SetActive(true);
            canUseForceField = false;
            hasUsedForceField = true;
            randNum = 0;
        }
        if (canUseZeroBlades)
        {
            Debug.Log("UsedZeroBlades");
            //Instanciar ZeroBlades
            canUseZeroBlades = false;
            randNum = 0;
        }
    }
}
