using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile
{
    Vector3Int _index;
    bool[] _PossibleSamples; // 
   
    public Tile ()
    {

    }

    public Tile(int x, int y, int z)
    {
        _index = new Vector3Int(x, y, z);
    }
}
