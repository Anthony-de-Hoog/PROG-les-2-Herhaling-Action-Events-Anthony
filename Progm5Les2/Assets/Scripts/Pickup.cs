using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static event Action OnPickup;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Player collision detected");
            OnPickup?.Invoke();

            Destroy(gameObject);
        }
        
    }
}
