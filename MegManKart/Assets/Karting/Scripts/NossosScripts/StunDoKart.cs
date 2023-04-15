using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunDoKart : MonoBehaviour
{
    public Rigidbody rigidbody;
    public BoxCollider Colider;
    public float StunDuration = 2f;
    private float StunDurationTime;
    private bool Stuned = false;

    private void Start()
    {
        StunDurationTime = StunDuration;
    }

    private void FixedUpdate()
    {
        if (Stuned == true)
        {
            StunDurationTime -= Time.deltaTime;
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (StunDurationTime <= 0)
        {
            Stuned = false;
            StunDurationTime = StunDuration;
            rigidbody.constraints = RigidbodyConstraints.None;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.CompareTag("STUNN"))
        {
            Stuned = true;
        }
    }
}