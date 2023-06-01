using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (mainCamera != null)
        {
            Vector3 lookAtPosition = mainCamera.transform.position;
            lookAtPosition.y = transform.position.y; // Optional: Keep the object's original y-position
            transform.LookAt(lookAtPosition);
            transform.Rotate(0, 180, 0); // Rotate the object by 180 degrees around the y-axis
        }
    }
}