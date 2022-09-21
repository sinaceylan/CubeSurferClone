using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();
    private GameObject lastBlock;

    private void Start()
    {
        UpdateLastBlockObject();
    }

    public void IncreaseNewBlock(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1.2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlock.transform.position.x, lastBlock.transform.position.y - 1.2f, lastBlock.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);
        UpdateLastBlockObject();
    }


    public void DecreaseBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlockObject();
    }


    public void UpdateLastBlockObject()
    {
        lastBlock = blockList[blockList.Count - 1];
    }
}
