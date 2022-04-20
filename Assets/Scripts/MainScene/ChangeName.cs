using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    [SerializeField] InputField g_Input;
    [SerializeField] InputField g_Output;
    [SerializeField] Button g_ChangeButton;

    public void Initialize()
    {
        g_Input.text = "";
        g_Output.text = "";
    }

    // Start is called before the first frame update
    void Start()
    {
        g_ChangeButton.onClick.AddListener(OnClick_Change);
    }

    void OnClick_Change()
    {
        string input = g_Input.text;

        Debug.Log(input[2]);

        string result = string.Empty;

        for(int i = 0; i < input.Length; i++)
        {
            string r = GameInfo.Instance.GetRandomChangeWord(input[i].ToString());
            result += r;
        }

        g_Output.text = result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
