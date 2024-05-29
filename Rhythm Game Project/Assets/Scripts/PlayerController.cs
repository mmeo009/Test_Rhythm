using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    public bool isGravityChanged = false;
    public float moveSpeed;
    void Update()
    {
        gameObject.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeGravity();
        }    
    }

    private void ChangeGravity()
    {
        if(isGravityChanged == false)
        {
            transform.DORotate(new Vector3(0, 0, 180), moveSpeed / 2, RotateMode.Fast).OnComplete(() => { transform.DOMoveY(transform.position.y + 3, moveSpeed / 2).OnComplete(() => { isGravityChanged = true; }); });
        }
        else
        {
            transform.DORotate(new Vector3(0, 0, 0), moveSpeed / 2, RotateMode.Fast).OnComplete(() => { transform.DOMoveY(transform.position.y - 3, moveSpeed / 2).OnComplete(() => { isGravityChanged = false; }); });
        }
    }
}
