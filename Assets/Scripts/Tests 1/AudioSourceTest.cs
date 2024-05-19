using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class AudioSourceTest
{
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestAudioSourceBGMPlay()
    {
        GameObject obj = new GameObject();
        GameObject obj2 = new GameObject();
        AudioSource audio = obj2.AddComponent<AudioSource>();
        AudioPlayer logic = obj.AddComponent<AudioPlayer>();
        logic.audioSource = audio;
        AudioSource audioSource = logic.audioSource;
        AudioClip clip = AudioClip.Create("TestClip", 44100, 1, 44100, false);
        logic.audioClip = clip;
        yield return new WaitForSeconds(0.1f);
        logic.PlayBGM();
        Assert.IsTrue(audioSource.isPlaying);
    }
    
    [UnityTest]
    public IEnumerator TestBGMPlay()
    {
        GameObject obj = new GameObject();
        GameObject obj2 = new GameObject();
        AudioSource audio = obj2.AddComponent<AudioSource>();
        AudioPlayer logic = obj.AddComponent<AudioPlayer>();
        logic.audioSource = audio;
        AudioSource audioSource = logic.audioSource;
        AudioClip clip = AudioClip.Create("TestClip", 44100, 1, 44100, false);
        logic.audioClip = clip;
        yield return new WaitForSeconds(0.1f);
        logic.PlayBGM();
        Assert.AreEqual(clip, audioSource.clip);
    }
}
