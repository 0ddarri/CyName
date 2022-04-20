using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    public HudUI g_UI;

    private void Awake()
    {
        GameInfo.Instance.Initialize("Info/WordInfo");
    }

    // Start is called before the first frame update
    void Start()
    {
        g_UI.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
