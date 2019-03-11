using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TileGrid
{
    Vector3Int _size;
    int _north; // rotatation of the north compared to the y-axis
    Tile[,,] _tiles;

    public TileGrid()
    {

    }

    public TileGrid(Vector3Int size)
    {
        _size = size;
    }

    public void CreateGrid()
    {
        MakeTiles();
    }

    /// <summary>
    /// Generate the tile grid
    /// </summary>
    void MakeTiles()
    {
        // make voxels
        _tiles = new Tile[_size.x, _size.y, _size.z];

        for (int z = 0; z < _size.z; z++)
            for (int y = 0; y < _size.y; y++)
                for (int x = 0; x < _size.x; x++)
                    _tiles[x, y, z] = new Tile(x, y, z);
    }
}
