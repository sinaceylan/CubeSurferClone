using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();
    private GameObject lastBlock;
    public bool isStack = false;

    void Start()
    {
        UpdateLastBlock();
    }

    private void OnTriggerEnter(Collider other)
    {
       
            if (!isStack && other.tag == "SpawnCube")
            {
                isStack = !isStack;
                IncreaseNewBlock(other.gameObject);
                //SetDirection();
            }
            if (other.tag == "WallCube")
            {
                DecreaseBlock(other.gameObject);
            }
     
    }

    private void OnTriggerExit(Collider other)
    {

        isStack = false;

    }

    public void IncreaseNewBlock(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1.2f , transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlock.transform.position.x, lastBlock.transform.position.y - 1.2f, lastBlock.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);
        UpdateLastBlock();
    }
    public void DecreaseBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlock();
    }

    public void UpdateLastBlock()
    {
        lastBlock = blockList[blockList.Count - 1];
    }
    
}
