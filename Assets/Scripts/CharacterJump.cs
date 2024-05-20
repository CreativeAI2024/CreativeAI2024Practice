using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody m_rigidbody;
    /// <summary>
    /// 地面にいるかどうかを表すフラグ
    /// </summary>
    /// <remarks>
    /// 制御はこのスクリプト内で行う
    /// </remarks>
    public bool isGround = true;
    public float jumpPower = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// 地面にいるときに<see cref="m_rigidbody"/>のオブジェクトを<see cref="jumpPower"/>の力で上にジャンプさせる処理を書いてね
    /// <see cref="isGround"/>も考慮してね
    /// </summary>
    public void Jump()
    {
        
    }
    
    /// <summary>
    /// 地面オブジェクト(Groundタグがついている)に衝突したときだけ<see cref="isGround"/>をtrueにする処理を書いてね
    /// </summary>
    /// <param name="other">衝突したオブジェクト</param>
    public void OnCollisionEnter(Collision other)
    {
        
    }
}
