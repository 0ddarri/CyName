using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CSVParser
{
    public static List<string[]> Load(string path)
    {
        List<string[]> _dataList = new List<string[]>();

        TextAsset _textAsset = Resources.Load<TextAsset>(path);
        if (_textAsset == null) return null;

        StringReader sr = new StringReader(_textAsset.text);

        string inputData = sr.ReadLine();
        while (inputData != null)
        {
            string[] datas = inputData.Split('\t');
            if (datas.Length == 0) continue;
            _dataList.Add(datas);
            inputData = sr.ReadLine();
        }
        sr.Close();
        return _dataList;
    }
}
