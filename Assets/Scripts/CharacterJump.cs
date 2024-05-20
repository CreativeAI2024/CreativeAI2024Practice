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
    
    public void Jump()
    {
        // 地面にいるときにm_rigidbodyのオブジェクトをjumpPowerの力で上にジャンプさせる処理を書いてね
        // isGroundも考慮してね
    }

    public void OnCollisionEnter(Collision other)
    {
        // 地面オブジェクト(Groundタグがついている)に衝突したときだけisGroundをtrueにする処理を書いてね
    }
}
