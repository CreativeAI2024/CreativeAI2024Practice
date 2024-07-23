using System.Collections;
using System.Linq;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests_1
{
    public class ObjectLoadTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void ObjectAlreadyExistsTest()
        {
            Assert.IsNull(GameObject.Find("Cube(Clone)"));
        }
        
        [UnityTest]
        public IEnumerator ObjectLoadAndInstantiateTest()
        {
            GameObject obj = new GameObject();
            ObjectLoader loader = obj.AddComponent<ObjectLoader>();
            loader.LoadAndInstantiate();
            yield return null;
            GameObject loadObj = GameObject.Find("Cube(Clone)");
            Assert.IsNotNull(loadObj);
            Object.DestroyImmediate(loadObj);
        }
    }
}
