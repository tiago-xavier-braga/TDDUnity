using System.Collections;
using NUnit.Framework;
using TDDUnity.Manager;
using UnityEngine;
using UnityEngine.TestTools;

namespace TDDUnity.Tests
{
    public class HeartValuesTests
    {
        public class HeartManipulationTest : MonoBehaviour
        {
            public float SetHeartValue(float value)
            {
                LifeSystemManager lifeSystemManager = new();
                return lifeSystemManager.SetValues(value);
            }
            [Test]
            public void IncleaseHeartValue()
            {
                Assert.AreEqual(SetHeartValue(1), 2f);
            }

            [Test]
            public void DecreaseHeartValue()
            {
                Assert.AreEqual(SetHeartValue(-1), 0f);
            }
        }
    }
}
