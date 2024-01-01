using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TDDUnity.Manager
{
    public class LifeSystemManager : MonoBehaviour
    {
        public float currentLife = 1f;
        public float SetValues(float value)
        {
            return currentLife = currentLife + value;
        }
    }
}
