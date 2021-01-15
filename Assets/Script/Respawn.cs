using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawn;
    private void OnTriggerEnter(Collider Deadzone)
    {
        Deadzone.transform.position = respawn.transform.position;


    }
}
