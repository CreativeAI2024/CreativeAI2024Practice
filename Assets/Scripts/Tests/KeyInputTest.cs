using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyInputTest : InputTestFixture
{
    // A Test behaves as an ordinary method
    [Test]
    public void WKeyInputMoveTest()
    {
        GameObject obj = new GameObject();
        CharacterControl cc = obj.AddComponent<CharacterControl>();
        var keyboard = InputSystem.AddDevice<Keyboard>();
        Press(keyboard.wKey);
        cc.UpdateMove();
        Assert.Greater(cc.transform.position.z, 0);
    }
    
    [Test]
    public void AKeyInputMoveTest()
    {
        GameObject obj = new GameObject();
        CharacterControl cc = obj.AddComponent<CharacterControl>();
        var keyboard = InputSystem.AddDevice<Keyboard>();
        Press(keyboard.aKey);
        cc.UpdateMove();
        Assert.Less(cc.transform.position.x, 0);
    }
    
    [Test]
    public void SKeyInputMoveTest()
    {
        GameObject obj = new GameObject();
        CharacterControl cc = obj.AddComponent<CharacterControl>();
        var keyboard = InputSystem.AddDevice<Keyboard>();
        Press(keyboard.sKey);
        cc.UpdateMove();
        Assert.Less(cc.transform.position.z, 0);
    }
    
    [Test]
    public void DKeyInputMoveTest()
    {
        GameObject obj = new GameObject();
        CharacterControl cc = obj.AddComponent<CharacterControl>();
        var keyboard = InputSystem.AddDevice<Keyboard>();
        Press(keyboard.dKey);
        cc.UpdateMove();
        Assert.Greater(cc.transform.position.x, 0);
    }
    
    [Test]
    public void SameTimeInputTest()
    {
        GameObject obj = new GameObject();
        CharacterControl cc = obj.AddComponent<CharacterControl>();
        var keyboard = InputSystem.AddDevice<Keyboard>();
        Press(keyboard.wKey);
        Press(keyboard.aKey);
        cc.UpdateMove();
        Assert.AreEqual(new Vector3(-1, 0, 1), cc.transform.position);
    }
    
    [Test]
    public void SameTimeInputSimpleTest()
    {
        GameObject obj = new GameObject();
        CharacterControl cc = obj.AddComponent<CharacterControl>();
        var keyboard = InputSystem.AddDevice<Keyboard>();
        Press(keyboard.sKey);
        Press(keyboard.dKey);
        cc.UpdateMove();
        Assert.AreEqual(new Vector3(1, 0, -1), cc.transform.position);
    }
    
    [Test]
    public void PressKeyInputTest()
    {
        GameObject obj = new GameObject();
        CharacterControl cc = obj.AddComponent<CharacterControl>();
        var keyboard = InputSystem.AddDevice<Keyboard>();
        Press(keyboard.aKey);
        cc.UpdateMove();
        InputSystem.Update();
        cc.UpdateMove();
        Assert.AreEqual(new Vector3(-2, 0, 0), cc.transform.position);
    }
}

