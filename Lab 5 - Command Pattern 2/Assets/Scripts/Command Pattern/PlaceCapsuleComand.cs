using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCapsuleComand : MonoBehaviour
{ 
 Vector3 position;
Color color;
Transform cube;

public PlaceCapsuleComand(Vector3 position, Color color, Transform capsule)
{
    this.position = position;
    this.color = color;
    this.capsule = capsule;
}

public void Execute()
{
    CapsulePlacer.PlaceCapsule(position, color, cube);
}

public void Undo()
{
    CapsulePlacer.RemoveCapsule(position, color);
}
}
