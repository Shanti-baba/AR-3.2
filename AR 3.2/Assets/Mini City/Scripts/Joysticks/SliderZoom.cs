using UnityEngine;
using UnityEngine.UI;

public class SliderZoom : MonoBehaviour
{
    public Slider scaleSlider;

    private float scaleSliderNumber;
    
    void Update()
    {
        scaleSliderNumber = scaleSlider.value;
        Vector3 scale = new Vector3(scaleSliderNumber, scaleSliderNumber, scaleSliderNumber);
        this.transform.localScale = scale;
    }

    
}