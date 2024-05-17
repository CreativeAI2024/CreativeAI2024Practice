using System.Collections;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests_1
{
    public class SceneTest
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        [LoadScene("Assets/Scenes/SampleScene.unity")]
        public IEnumerator SceneChangeTest()
        {
            GameObject obj = new GameObject();
            SceneChanger changer = obj.AddComponent<SceneChanger>();
            changer.SceneChange();
            yield return null;
            Assert.AreNotEqual("SampleScene" ,SceneManager.GetActiveScene().name);
        }
        
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        [LoadScene("Assets/Scenes/SampleScene.unity")]
        public IEnumerator SceneChangeToTest()
        {
            GameObject obj = new GameObject();
            SceneChanger changer = obj.AddComponent<SceneChanger>();
            changer.SceneChange();
            yield return null;
            Assert.AreEqual("NewScene" ,SceneManager.GetActiveScene().name);
        }
    }
    
    public class LoadSceneAttribute : NUnitAttribute, IOuterUnityTestAction
    {
        private string scene;
 
        public LoadSceneAttribute(string scene) => this.scene = scene;
 
        IEnumerator IOuterUnityTestAction.BeforeTest(ITest test)
        {
            yield return EditorSceneManager.LoadSceneAsyncInPlayMode(scene, new LoadSceneParameters(LoadSceneMode.Single));
        }
 
        IEnumerator IOuterUnityTestAction.AfterTest(ITest test)
        {
            yield return null;
        }
    }
}
