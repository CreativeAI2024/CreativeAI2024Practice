using NUnit.Framework;
using UnityEngine;

public class TransformTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void TransformTestSimplePasses()
    {
        GameObject obj = new GameObject();
        CharacterMove logic = obj.AddComponent<CharacterMove>();
        Vector3 beforePosition = logic.transform.position;
        logic.MovePosition();
        Assert.AreNotEqual(beforePosition, logic.transform.position);
    }
    
    [Test]
    public void TransformTestToPosition()
    {
        GameObject obj = new GameObject();
        CharacterMove logic = obj.AddComponent<CharacterMove>();
        logic.MovePosition();
        Assert.AreEqual(logic.to, logic.transform.position);
    }
}
