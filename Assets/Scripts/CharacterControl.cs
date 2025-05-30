
using UnityEngine.InputSystem;
using Util;
using Vector3 = UnityEngine.Vector3;

public class CharacterControl : UnityEngine.MonoBehaviour
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
    /// <see cref="Key.W">Wキー</see>を押している間このオブジェクトが奥に動いて
    /// <see cref="Key.A">Aキー</see>を押している間このオブジェクトが左に動いて
    /// <see cref="Key.S">Sキー</see>を押している間このオブジェクトが手前に動いて
    /// <see cref="Key.D">Dキー</see>を押している間このオブジェクトが右に動く処理を書いてね
    /// </summary>
    /// <remarks>
    /// <see cref="UnityEngine.Input"/>クラスの代わりに<see cref="Util.ShiruronaInput"/>クラスを使ってね
    /// </remarks>
    public void UpdateMove()
    {
        if (Util.ShiruronaInput.GetKey(Key.W))
        {
            this.transform.position += new Vector3(0, 0, 1.0f);
        }
        if (Util.ShiruronaInput.GetKey(Key.A))
        {
            this.transform.position += new Vector3(-1.0f, 0, 0);
        }
        if (Util.ShiruronaInput.GetKey(Key.S))
        {
            this.transform.position += new Vector3(0, 0, -1.0f);
        }
        if (Util.ShiruronaInput.GetKey(Key.D))
        {
            this.transform.position += new Vector3(1.0f, 0, 0);
        }

    }
}


