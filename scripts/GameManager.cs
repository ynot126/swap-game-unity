using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform block;
    void Awake()
    {
        // spawn all block in the game and the players
        for (int x = 0; x < transform.childCount; x++){
            if (transform.GetChild(x).CompareTag("Respawn"))
            {
                Instantiate(player, transform.GetChild(x).transform.position, transform.GetChild(x).transform.rotation);
            }
            else if (transform.GetChild(x).CompareTag("block_spawn"))
            {
                Instantiate(block, transform.GetChild(x).transform.position, transform.GetChild(x).transform.rotation);
            }
        }
    }
}
