using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    public void SpawnObject()
    {
        Instantiate(player, transform.position, player.transform.rotation);
    }
}
