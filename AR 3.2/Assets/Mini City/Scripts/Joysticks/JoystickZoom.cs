using UnityEngine;
using UnityEngine.UI;

public class JoystickZoom : MonoBehaviour
{
    public Joystick joystick;
    public float minScale = 0.5f;
    public float maxScale = 2.0f;
    public float scaleSpeed = 0.1f;

    private Vector3 initialScale;
    private float savedVerticalInput;

    private void Start()
    {
        initialScale = transform.localScale;
        savedVerticalInput = joystick.Vertical;
    }

    private void Update()
    {
        float verticalInput = joystick.Vertical;
        if (verticalInput != 0)
            savedVerticalInput = verticalInput;

        float scaleFactor = 1.0f + savedVerticalInput * scaleSpeed;
        Vector3 newScale = initialScale * scaleFactor;
        newScale = ClampScale(newScale, minScale, maxScale);
        transform.localScale = newScale;
    }

    private Vector3 ClampScale(Vector3 scale, float min, float max)
    {
        scale.x = Mathf.Clamp(scale.x, min, max);
        scale.y = Mathf.Clamp(scale.y, min, max);
        scale.z = Mathf.Clamp(scale.z, min, max);
        return scale;
    }
}