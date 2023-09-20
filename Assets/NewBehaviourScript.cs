using System.Collections;
using System.Collections.Generic; using UnityEngine;

public class InteractionController : MonoBehaviour {
    public GameObject objectToChangeColor;
    private Renderer objectRenderer;

    void Start() {
        objectRenderer = objectToChangeColor.GetComponent<Renderer>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) // Left mouse button clicked
        {
            // Change the color of the object to red
            objectRenderer.material.color = Color.red;
        }
        else if (Input.GetMouseButtonDown(1)) // Right mouse button clicked
        {
        // Change the color of the object to blue
            objectRenderer.material.color = Color.blue; 
        }
    } 
    }