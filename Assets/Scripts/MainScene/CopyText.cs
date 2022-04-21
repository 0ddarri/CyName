using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyText : MonoBehaviour
{
    public void Initialize()
    {
        gameObject.SetActive(true);
        Invoke("Off", 2.0f);
    }

    void Off()
    {
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
