using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using UnityEngine;

public class FileReadTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void FileReadTestSimplePasses()
    {
        // Use the Assert class to test conditions
        string filename = "test.txt";
        string content = "testtesttesttesttest\r\n";
        string path = Path.Combine(Application.persistentDataPath, filename);
        if (!File.Exists(path))
        {
            using FileStream fs = File.Create(path);
            using StreamWriter sw = new StreamWriter(fs);
            sw.Write(content);
        }
        FileReader fr = new FileReader(filename);
        Assert.AreEqual(content, fr.LoadUserTextFile());
    }
    
    [Test]
    public void FileReadTest2()
    {
        // Use the Assert class to test conditions
        string filename = "sample.txt";
        string content = "aoeiugntskf:\r\n";
        string path = Path.Combine(Application.persistentDataPath, filename);
        if (!File.Exists(path))
        {
            using FileStream fs = File.Create(path);
            using StreamWriter sw = new StreamWriter(fs);
            sw.Write(content);
        }
        FileReader fr = new FileReader(filename);
        Assert.AreEqual(content, fr.LoadUserTextFile());
        File.Delete(path);
    }
}
