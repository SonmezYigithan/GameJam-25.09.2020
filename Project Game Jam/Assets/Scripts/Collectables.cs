using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    GameObject gameControl;
    private void Start()
    {
        gameControl = GameObject.FindWithTag("GameControl");
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //change score
        // += 1;
        GameControllerScript gameControllerScript = gameControl.GetComponent<GameControllerScript>();
        gameControllerScript.Score += 1;
        Destroy(gameObject);
    }
}
