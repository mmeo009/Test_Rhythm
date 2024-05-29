using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraController : MonoBehaviour
{
    public PlayerController player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if(player.isGravityChanged == false)
        {
            transform.DOMove(new Vector3(player.transform.position.x, player.transform.position.y + 3, player.transform.position.z - 10), player.moveSpeed/2);
        }
        else
        {
            transform.DOMove(new Vector3(player.transform.position.x, player.transform.position.y + 2, player.transform.position.z - 10), player.moveSpeed/2);
        }
        transform.DOLookAt(player.transform.position, player.moveSpeed);
    }

}
