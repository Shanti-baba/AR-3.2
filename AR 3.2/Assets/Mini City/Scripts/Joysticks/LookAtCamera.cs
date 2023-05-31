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
            transform.LookAt(mainCamera.transform);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);

        }
    }
}