using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipBoard
{
    TextEditor g_te;
    string g_Clip;

    static public string clip
    {
        get
        {
            TextEditor te = new TextEditor();
            te.Paste();
            Debug.Log("Paste");
            return te.text;
        }
        set
        {
            TextEditor te = new TextEditor();
            te.text = value;
            te.OnFocus();
            te.Copy();
            Debug.Log("Copy");
        }
    }
}
