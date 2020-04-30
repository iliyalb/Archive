using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Shapes;

public class ShapeDesignerWindow : EditorWindow {

    private Rect shapeIconSection;
    private Texture2D shapeIconTexture;

    private Texture2D currentShape;

    private Texture2D cubeIcon;
    private Texture2D sphereIcon;
    private Texture2D capsuleIcon;
    private Texture2D cylinderIcon;

    private ShapeTypes shapeType;
    private Vector3 shapePosition;
    private Vector3 shapeRotation;
    private Color shapeColor;
    private float shapeScale;
    private string shapeName;

    private bool ShowRandomOptions;
    private float minPos;
    private float maxPos;
    private float maxRot;
    private float maxScale;

    private bool ShowSpacingOptions;
    private int numOfShapes;
    private Vector3 spacing;

    [MenuItem("Window/Shape Designer")]
	static void OpenWindow()
    {
        ShapeDesignerWindow window = (ShapeDesignerWindow)GetWindow(typeof(ShapeDesignerWindow));
        window.minSize = new Vector2(200f, 200f);
        window.Show();
    }

    private void OnEnable()
    {
        InitTextures();
    }

    private void InitTextures()
    {
        shapeIconTexture = new Texture2D(1, 1);
        shapeIconTexture.SetPixel(0, 0, Color.blue);
        shapeIconTexture.Apply();
        shapeName = "Test Cube";

        cubeIcon = Resources.Load<Texture2D>("icons/cube_icon");
        sphereIcon = Resources.Load<Texture2D>("icons/sphere_icon");
        capsuleIcon = Resources.Load<Texture2D>("icons/capsule_icon");
        cylinderIcon = Resources.Load<Texture2D>("icons/cylinder_icon");
    }

    private void OnGUI()
    {
        ChangeShape();
        DrawLayouts();
        DrawShapeSettings();
    }

    private void ChangeShape()
    {
        switch(shapeType)
        {
            case ShapeTypes.CUBE:
                {
                    currentShape = cubeIcon;
                    break;
                }
            case ShapeTypes.SPHERE:
                {
                    currentShape = sphereIcon;
                    break;
                }
            case ShapeTypes.CAPSULE:
                {
                    currentShape = capsuleIcon;
                    break;
                }
            case ShapeTypes.CYLINDER:
                {
                    currentShape = cylinderIcon;
                    break;
                }
        }
    }

    private void DrawLayouts()
    {
        shapeIconSection.x = Screen.width / 3f;
        shapeIconSection.y = 350;
        shapeIconSection.width = 300;
        shapeIconSection.height = 300;

        GUI.DrawTexture(shapeIconSection, currentShape);
    }

    private void DrawShapeSettings()
    {
        GUILayout.Label("Create Your Shape");

        EditorGUILayout.BeginHorizontal();
        shapeType = (ShapeTypes)EditorGUILayout.EnumPopup(shapeType);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        shapePosition = EditorGUILayout.Vector3Field("Shape Position:", shapePosition);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        shapeRotation = EditorGUILayout.Vector3Field("Shape Rotation:", shapeRotation);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Shape Scale:");
        shapeScale = EditorGUILayout.Slider(shapeScale, 1, 10);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        shapeColor = EditorGUILayout.ColorField("Shape Color:", shapeColor);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        shapeName = EditorGUILayout.TextField("Shape Name:", shapeName);
        EditorGUILayout.EndHorizontal();

        ShowRandomOptions = EditorGUILayout.Foldout(ShowRandomOptions, "Show Variable Options");
        if (ShowRandomOptions)
        {
            minPos = EditorGUILayout.FloatField("Minimum Position Value", minPos);

            maxPos = EditorGUILayout.FloatField("Maximum Position Value", maxPos);

            maxRot = EditorGUILayout.FloatField("Maximum Rotation Value", maxRot);

            maxScale = EditorGUILayout.FloatField("Maximum Scale Value", maxScale);
        }

        ShowSpacingOptions = EditorGUILayout.Foldout(ShowSpacingOptions, "Spacing Variable Options");
        if (ShowSpacingOptions)
        {
            EditorGUILayout.BeginHorizontal();
            numOfShapes = EditorGUILayout.IntField("Number of Shapes:", numOfShapes);
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            spacing = EditorGUILayout.Vector3Field("Spacing:", spacing);
            EditorGUILayout.EndHorizontal();
        }

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Randomize Variables"))
        {
            CreateShape(true);
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Create Shape"))
        {
            CreateShape(false);
        }
        EditorGUILayout.EndHorizontal();

        if (shapeName.Length == 0)
        {
            EditorGUILayout.HelpBox("The shape needs a name", MessageType.Error);
        }
        else
        {
            if (shapeName.StartsWith(" "))
            {
                EditorGUILayout.HelpBox("Name cannot start with a space", MessageType.Error);
            }
        }
    }

    private void CreateShape(bool Randomize)
    {
        if (shapeName.Length == 0 || shapeName.StartsWith(" ")) return;

        switch(shapeType)
        {
            case ShapeTypes.CUBE:
                {
                    

                    if (!Randomize)
                    {
                        if (numOfShapes > 0)
                        {
                            for(int i = 0; i < numOfShapes; i++)
                            {
                                GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Cube);
                                shape.transform.position = spacing * i;

                                var NewMaterial = new Material(shape.GetComponent<Renderer>().sharedMaterial);
                                NewMaterial.color = shapeColor;
                                shape.GetComponent<Renderer>().sharedMaterial = NewMaterial;

                                shape.name = shapeName + " " + i.ToString();
                            }
                        }
                        else
                        {
                            GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            SetTransform(shape);
                        }
                        
                    }
                    else
                    {
                        GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        RandomizeTransform(shape);
                    }

                    
                    break;
                }
            case ShapeTypes.SPHERE:
                {
                    if (!Randomize)
                    {
                        if (numOfShapes > 0)
                        {
                            for (int i = 0; i < numOfShapes; i++)
                            {
                                GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                                shape.transform.position = spacing * i;

                                var NewMaterial = new Material(shape.GetComponent<Renderer>().sharedMaterial);
                                NewMaterial.color = shapeColor;
                                shape.GetComponent<Renderer>().sharedMaterial = NewMaterial;

                                shape.name = shapeName + " " + i.ToString();
                            }
                        }
                        else
                        {
                            GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                            SetTransform(shape);
                        }
                    }
                    else
                    {
                        GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        RandomizeTransform(shape);
                    }
                    break;
                }
            case ShapeTypes.CAPSULE:
                {
                    if (!Randomize)
                    {

                        if (numOfShapes > 0)
                        {
                            for (int i = 0; i < numOfShapes; i++)
                            {
                                GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                                shape.transform.position = spacing * i;

                                var NewMaterial = new Material(shape.GetComponent<Renderer>().sharedMaterial);
                                NewMaterial.color = shapeColor;
                                shape.GetComponent<Renderer>().sharedMaterial = NewMaterial;

                                shape.name = shapeName + " " + i.ToString();
                            }
                        }
                        else
                        {
                            GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                            SetTransform(shape);
                        }
                    }
                    else
                    {
                        GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                        RandomizeTransform(shape);
                    }
                    break;
                }
            case ShapeTypes.CYLINDER:
                {
                    if (!Randomize)
                    {

                        if (numOfShapes > 0)
                        {
                            for (int i = 0; i < numOfShapes; i++)
                            {
                                GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                                shape.transform.position = spacing * i;

                                var NewMaterial = new Material(shape.GetComponent<Renderer>().sharedMaterial);
                                NewMaterial.color = shapeColor;
                                shape.GetComponent<Renderer>().sharedMaterial = NewMaterial;

                                shape.name = shapeName + " " + i.ToString();
                            }
                        }
                        else
                        {
                            GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                            SetTransform(shape);
                        }
                    }
                    else
                    {
                        GameObject shape = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                        RandomizeTransform(shape);
                    }
                    break;
                }
        }
    }

    private void RandomizeTransform(GameObject NewShape)
    {
        float newPos = Random.Range(minPos, maxPos);
        float newRot = Random.Range(0, maxRot);
        float newScale = Random.Range(0, maxScale);

        NewShape.transform.position = new Vector3(newPos, newPos, newPos); ;
        NewShape.transform.eulerAngles = new Vector3(newRot, newRot, newRot);
        NewShape.transform.localScale = new Vector3(newScale, newScale, newScale);

        var NewMaterial = new Material(NewShape.GetComponent<Renderer>().sharedMaterial);
        NewMaterial.color = shapeColor;
        NewShape.GetComponent<Renderer>().sharedMaterial = NewMaterial;

        NewShape.name = shapeName;
    }

    private void SetTransform(GameObject NewShape)
    {
        NewShape.transform.position = shapePosition;
        NewShape.transform.eulerAngles = shapeRotation;
        NewShape.transform.localScale = new Vector3(shapeScale, shapeScale, shapeScale);

        var NewMaterial = new Material(NewShape.GetComponent<Renderer>().sharedMaterial);
        NewMaterial.color = shapeColor;
        NewShape.GetComponent<Renderer>().sharedMaterial = NewMaterial;

        NewShape.name = shapeName;
    }
}
