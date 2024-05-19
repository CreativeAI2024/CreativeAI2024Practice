using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CollisionTest
{
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator CollisionSimpleTest()
    {
        GameObject obj = new GameObject();
        obj.AddComponent<BoxCollider>();
        obj.AddComponent<Rigidbody>();
        CharacterJump logic = obj.AddComponent<CharacterJump>();
        logic.isGround = false;
        GameObject obj2 = new GameObject();
        obj2.AddComponent<BoxCollider>();
        obj2.AddComponent<Rigidbody>();
        obj.transform.position = Vector3.zero;
        obj2.transform.position = Vector3.zero;
        obj2.tag = "Untagged";
        yield return new WaitForFixedUpdate();
        // CollisionEnterが呼ばれる
        Assert.IsFalse(logic.isGround);
    }
    
    [UnityTest]
    public IEnumerator CollisionTagTest()
    {
        GameObject obj = new GameObject();
        obj.AddComponent<BoxCollider>();
        obj.AddComponent<Rigidbody>();
        CharacterJump logic = obj.AddComponent<CharacterJump>();
        logic.isGround = false;
        GameObject obj2 = new GameObject();
        obj2.AddComponent<BoxCollider>();
        obj2.AddComponent<Rigidbody>();
        obj.transform.position = Vector3.zero;
        obj2.transform.position = Vector3.zero;
        obj2.tag = "Ground";
        yield return new WaitForFixedUpdate();
        // CollisionEnterが呼ばれる
        Assert.IsTrue(logic.isGround);
    }
}
