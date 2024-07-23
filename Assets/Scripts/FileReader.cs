using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileReader
{
    private string _filename;

    public FileReader(string filename)
    {
        _filename = filename;
    }
    
    /// <summary>
    /// <see cref="Application.persistentDataPath"/>にあるファイル名が<see cref="_filename"/>のファイルをロードして内容を返す処理を書いてね
    /// </summary>
    /// <remarks>
    /// usingキーワードを適切に使用すること
    /// </remarks>
    /// <returns>ファイルの内容</returns>
    public string LoadUserTextFile()
    {
        return null;
    }
}
