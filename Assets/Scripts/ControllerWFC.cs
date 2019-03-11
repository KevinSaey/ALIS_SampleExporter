using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerWFC : MonoBehaviour
{
    [SerializeField]
    Vector3Int _size;

    TileGrid _tileGrid;

    void Start()
    {
        _tileGrid = new TileGrid(_size);
    }

    
    void Update()
    {
        
    }
}
