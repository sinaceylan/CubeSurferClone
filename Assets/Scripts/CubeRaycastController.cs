using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRaycastController : MonoBehaviour
{
    [SerializeField] private CharacterStackController characterStackController;
    private Vector3 direction = Vector3.back;
    private bool isStack = false;
    private RaycastHit hit;


    void Start()
    {
        characterStackController = GameObject.FindObjectOfType<CharacterStackController>();
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position,direction,out hit,1f))
        //if(Physics.BoxCast(transform.position,transform.lossyScale/2,transform.forward,out hit,Quaternion.identity,1f))
        {
            if (!isStack)
            {
                isStack = !isStack;
                characterStackController.IncreaseNewBlock(gameObject);
                SetDirection();
            }
            if (hit.transform.tag == "WallCube")
            {
                characterStackController.DecreaseBlock(gameObject);
            }
        }
    }
    private void SetDirection()
    {
        direction = Vector3.forward;
    }


}
