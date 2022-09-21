using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCont : MonoBehaviour
{
    private HeroStackController heroStackController;
    bool isPassable;

    private void Start()
    {
        heroStackController = GameObject.FindGameObjectWithTag("MainCube").GetComponent<HeroStackController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "WallCube" && !isPassable)
        {
            isPassable = true;  
            heroStackController.DecreaseBlock(this.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isPassable = false;
        
    }

}
