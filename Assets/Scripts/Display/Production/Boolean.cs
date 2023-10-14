using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Parabox.CSG;
using Parabox;

public class Boolean : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Initialize two new meshes in the scene
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = Vector3.one * 1.3f;

        sphere.GetComponent<MeshFilter>().mesh = GameObject.Find("a").GetComponent<MeshFilter>().mesh;

        // Perform boolean operation
        Parabox.CSG.Model result = CSG.Subtract(cube, sphere);

        // Create a gameObject to render the result
        var composite = new GameObject();
        composite.name = "booleaned";
        composite.transform.position = new Vector3(0, 0, 10);
        composite.AddComponent<MeshFilter>().sharedMesh = result.mesh;
        composite.AddComponent<MeshRenderer>().sharedMaterials = result.materials.ToArray();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
