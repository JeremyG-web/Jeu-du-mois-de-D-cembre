using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    public GameObject panel;
    public GameManager gameManager;
    public void OnTriggerEnter(Collider other)
    {
        gameManager.showPanel(panel);
        

    }
}
