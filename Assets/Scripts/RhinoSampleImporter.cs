using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

public class RhinoSampleImporter
{
    string _path;
    List<Sample> _assemblies = new List<Sample>();

    public RhinoSampleImporter(List<SamplePattern> samples)
    {
        _path = @"D:\Unity\ALIS_WFC\RhinoExport\";
        bool counting = true;
        int counter = 0;

        while (counting)
        {
            Sample assembly;
            var serializer = new XmlSerializer(typeof(Sample));
            try
            {
                using (var reader = XmlReader.Create($"{_path}sample_{counter}.xml"))
                {
                    assembly = serializer.Deserialize(reader) as Sample;
                }
                counter++;
                _assemblies.Add(assembly);
            }
            catch
            {
                Debug.Log(_assemblies.Count() + " samples imported");
                counting = false;
            }
        }
    }
}

/// <summary>
/// Assembly pattern existing of blocks 
/// </summary>
public class Sample //VS
{
    public List<Instance> Instances { get; set; }

    public int _idSample;
    public int _type;
    public List<List<int>> _possibleNeighbours;

    public static Sample Import(string fileName)
    {
        var serializer = new XmlSerializer(typeof(Sample));
        using (var reader = XmlReader.Create(fileName))
        {
            return serializer.Deserialize(reader) as Sample;
        }
    }
}

public class Instance
{
    public int DefinitionIndex;
    public Pose Pose;
}
