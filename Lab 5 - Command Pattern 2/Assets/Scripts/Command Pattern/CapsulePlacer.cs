using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulePlacer : MonoBehaviour
{
    static List<Transform> capsule;

    public static void PlaceCapsule(Vector3 position, Color color, Transform capsule)
    {
        Transform newCapsule = Instantiate(capsule, position, Quaternion.identity);
        newCapsule.GetComponentInChildren<MeshRenderer>().material.color = color;
        if (capsule == null)
        {
            capsule = new List<Transform>();
        }
        capsule.Add(newCapsule);
    }

    public static void RemoveCapsule(Vector3 position, Color color)
    {
        for (int i = 0; i < capsule.Count; i++)
        {
            if (capsule[i].position == position && capsule[i].GetComponentInChildren<MeshRenderer>().material.color == color)
            {
                GameObject.Destroy(capsule[i].gameObject);
                capsule.RemoveAt(i);
                break;
            }
        }
    }
}
