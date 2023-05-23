using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoystickColor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject handle;
    public Animator shoeos_Anim;
    private Image joystickHandleImage;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        joystickHandleImage = handle.GetComponentInChildren<Image>();
        originalColor = joystickHandleImage.color;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        shoeos_Anim.enabled = false;
        Debug.Log("Toucchhhh");
        joystickHandleImage.color = Color.red;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
        Debug.Log("Releseeee");
        joystickHandleImage.color = originalColor;
    }

}
