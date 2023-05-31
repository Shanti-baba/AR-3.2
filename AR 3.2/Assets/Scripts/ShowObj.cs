using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObj : MonoBehaviour
{
    public float initializedTime;
    public GameObject scene;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Initialize", initializedTime);
    }

    private void Initialize()
    {
        scene.SetActive(true);
    }
}
