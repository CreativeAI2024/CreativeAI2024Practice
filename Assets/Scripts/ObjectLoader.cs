using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// <summary>
    /// ResourcesフォルダにあるCubeオブジェクトをロードしてインスタンス化する処理を書いてね
    /// </summary>
    public void LoadAndInstantiate()
    {
        GameObject prefab = (GameObject)Resources.Load("Cube");
        Instantiate(prefab, new Vector3(-1.0f, 0.0f, 0.0f), Quaternion.identity);
        //Instantiate(prefab, position, Quaternion.identity);
    }
}
