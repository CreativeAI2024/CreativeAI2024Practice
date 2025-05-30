using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
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
        string read_data = "";

        
        string path = Path.Combine(Application.persistentDataPath,_filename);
        FileInfo file_info = new FileInfo(path);

        using (StreamReader sr = new StreamReader(file_info.OpenRead(), Encoding.UTF8))
        {
            // 最初から最後まで全部読み込む
            read_data = sr.ReadToEnd();
        }
        if (read_data != null)
            return read_data;
        else return null;
    }
}
