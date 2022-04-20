using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HudUI : MonoBehaviour
{
    [SerializeField] Button g_ExitButton;

    [SerializeField] ChangeName g_Name;

    public void Initialize()
    {
        g_Name.Initialize();
    }

    // Start is called before the first frame update
    void Start()
    {
        g_ExitButton.onClick.AddListener(OnClick_Exit);
    }

    void OnClick_Exit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
