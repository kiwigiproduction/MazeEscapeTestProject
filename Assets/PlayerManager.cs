using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    public Material shieldMat;
    public Material defaultMat;

    private bool immortal;

    private void Start()
    {
        immortal = true;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.GetComponent<Renderer>().material = shieldMat;
            immortal = false;
        }
        else
        {
            immortal = true;
            player.GetComponent<Renderer>().material = defaultMat;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Red" && immortal==true)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        else if (other.gameObject.tag == "Green")
        {
            FindObjectOfType<GameManager>().GameComplete();
        }
    }
}
