using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

namespace Tests
{
    public class ImageTest
    {
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [Test]
        public void ImageSimpleTest()
        {
            var obj = new GameObject();
            ShowImage logicObj = obj.AddComponent<ShowImage>();
            Texture2D texture2D = Texture2D.blackTexture;
            Rect rect = new Rect();
            Sprite s = Sprite.Create(texture2D, rect, Vector2.zero);
            var obj2 = new GameObject();
            Image img = obj2.AddComponent<Image>();
            logicObj.image = img;
            logicObj.sprite = s;
            logicObj.ChangeImage();
            Assert.AreEqual(s, logicObj.image.sprite);
        }
    }
}
