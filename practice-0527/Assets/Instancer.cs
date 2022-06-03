using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public int count;
    
    public Mesh mesh;
    public Material[] materials;

    private List<List<Matrix4x4>> _batches;

    void Start()
    {
        _batches = new List<List<Matrix4x4>>();
    }

    void Update()
    {
        foreach (var batch.List<Matrix4x4> in _batches)
        {
            for (int i=0; i< mesh.subMeshCount;++i)
            {
                
            }
        }
    }
}
