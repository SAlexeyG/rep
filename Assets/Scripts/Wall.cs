using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Wall : MonoBehaviour
{
    public void SetDefaultColor()
    {
        var meshRenderer = GetComponent<MeshRenderer>();
        var material = meshRenderer.sharedMaterial;
        material.color = Color.white;
        meshRenderer.sharedMaterial = material;
    }
}
