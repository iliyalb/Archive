using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Shapes;

[CreateAssetMenu(fileName ="New Shape Data", menuName = "Shape Data")]
public class ShapeData : ScriptableObject {

    public ShapeTypes _shapeTypes;
    public Vector3 Position;
    public string ShapeName;
}
