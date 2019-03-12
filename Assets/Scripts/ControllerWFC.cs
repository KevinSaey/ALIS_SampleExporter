using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerWFC : MonoBehaviour
{
    [SerializeField]
    Vector3Int _size;

    TileGrid _tileGrid;
    List<SamplePattern> _samples = new List<SamplePattern>();

    void Start()
    {
        _tileGrid = new TileGrid(_size);
        LoadSamples();
    }

    public void LoadSamples()
    {
        var rhinoImport = new RhinoSampleImporter(_samples);
    }
    
    
}
