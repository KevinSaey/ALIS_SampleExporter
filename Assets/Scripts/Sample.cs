using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SampleType { Empty, Facade, Appartment, Storage, Bathroom, Kitchen, Circulation }
public enum Axis { minX, plusX, minY, plusY, minZ, plusZ }


public class SamplePattern
{
    public List<Instance> Instances { get; set; }
    string _name;
    int _sampleId;
    List<SamplePattern>[] _possibleNeighbours = new List<SamplePattern>[6];
    SampleType _type;

    public SamplePattern(string name, int sampleId, SampleType type)
    {
        _name = name;
        _sampleId = sampleId;
        _type = type;
    }

    public void SetNeighbours(List<SamplePattern>[] _possibleNeighbours)
    {

    }
}
