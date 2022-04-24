using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameInfo
{
    static GameInfo inst = null;

    public static GameInfo Instance
    {
        get
        {
            if (inst == null) inst = new GameInfo();
            return inst;
        }
    }

    public List<string[]> g_WordInfo;

    public void Initialize(string filename)
    {
        try
        {
            g_WordInfo = CSVParser.Load(filename);
        }
        catch(Exception e)
        {
            Debug.Log(e);
        }
    }

    public string GetRandomChangeWord(string originWord)
    {
        string result = "";

        for(int i = 1; i < g_WordInfo.Count; i++)
        {
            if(g_WordInfo[i][0] == originWord)
            {
                int count = g_WordInfo[i].Length;
                Debug.Log("Count : " + count);
                int num = UnityEngine.Random.Range(0, count);
                result = g_WordInfo[i][num];
                Debug.Log("Find : " + result);
                break;
            }
        }
        return result;
    }
}
