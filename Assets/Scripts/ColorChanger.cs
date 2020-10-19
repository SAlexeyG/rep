using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorChanger : MonoBehaviour
{
    [MenuItem("GameObject/ChangeColors")]
    public static void ChangeColors()
    {
        foreach (var gameObject in FindObjectsOfType<MeshRenderer>())
        {
            var material = gameObject.sharedMaterial;
            material.color = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f));
            gameObject.sharedMaterial = material;
        }
    }
}
