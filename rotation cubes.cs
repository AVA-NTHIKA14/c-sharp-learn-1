using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSpeed = 50f;
    public Vector3 rotationAxis = Vector3.up;
    
    [Header("Color Settings")]
    public bool changeColor = false;
    public float colorChangeSpeed = 1f;
    
    private Renderer cubeRenderer;
    private float colorTimer = 0f;

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        Debug.Log("RotatingCube script started on: " + gameObject.name);
    }

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
        
        if (changeColor && cubeRenderer != null)
        {
            colorTimer += Time.deltaTime * colorChangeSpeed;
            Color newColor = Color.HSVToRGB(Mathf.PingPong(colorTimer, 1f), 1f, 1f);
            cubeRenderer.material.color = newColor;
        }
    }
    
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + rotationAxis * 2f);
    }
}
