using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Tile
{
    Vector3Int _index;
    bool[] _possibleSamples; //boolean list of all the remaining possible samples
    public int Entropy
    {
        get
        {
            return _possibleSamples.Count(b => b == true);
        }
    }

    public Tile()
    {

    }

    public Tile(int x, int y, int z)
    {
        _index = new Vector3Int(x, y, z);
    }
}
