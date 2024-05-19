using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class RigidbodyTest
{
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator RigidbodyJumpUpTest()
    {
        GameObject obj = new GameObject();
        CharacterJump logic = obj.AddComponent<CharacterJump>();
        logic.rigidbody = obj.AddComponent<Rigidbody>();
        Rigidbody rb = logic.rigidbody;
        logic.isGround = true;
        Vector3 beforeVelocity = rb.velocity;
        logic.Jump();
        yield return new WaitForFixedUpdate();
        Assert.Greater(rb.velocity.y, beforeVelocity.y);
    }
    
    [UnityTest]
    public IEnumerator RigidbodySimpleTest()
    {
        GameObject obj = new GameObject();
        CharacterJump logic = obj.AddComponent<CharacterJump>();
        logic.rigidbody = obj.AddComponent<Rigidbody>();
        Rigidbody rb = logic.rigidbody;
        Vector3 beforeVelocity = rb.velocity;
        logic.isGround = false;
        logic.Jump();
        yield return new WaitForFixedUpdate();
        Assert.LessOrEqual(rb.velocity.y, beforeVelocity.y);
    }
    
    
    [UnityTest]
    public IEnumerator RigidbodyJumpFlagTest()
    {
        GameObject obj = new GameObject();
        CharacterJump logic = obj.AddComponent<CharacterJump>();
        logic.rigidbody = obj.AddComponent<Rigidbody>();
        logic.isGround = true;
        logic.Jump();
        yield return new WaitForFixedUpdate();
        Assert.IsFalse(logic.isGround);
    }
}