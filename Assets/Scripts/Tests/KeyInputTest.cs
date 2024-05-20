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
        Assert.Greater(cc.transform.position.z, 0);
        Assert.Less(cc.transform.position.x, 0);
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
        Assert.Less(cc.transform.position.z, 0);
        Assert.Greater(cc.transform.position.x, 0);
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
        Vector3 movePos = cc.transform.position;
        cc.UpdateMove();
        Assert.AreNotEqual(Vector3.zero, cc.transform.position);
        Assert.AreEqual(movePos * 2, cc.transform.position);
    }
}

