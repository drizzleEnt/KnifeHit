using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singlton 
{
    public class Singlton<T> : MonoBehaviour where T: MonoBehaviour
    {
        private static T _instance;
        private static System.Object _lock = new System.Object();

        public static bool isApplicationQuitting;

        public static T Instance
        {
            get
            {
                if (isApplicationQuitting)
                    return null;

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = FindObjectOfType<T>();
                        if (_instance == null)
                        {
                            var singlton = new GameObject("{SINGLTON} " + typeof(T));
                            _instance = singlton.AddComponent<T>();
                            DontDestroyOnLoad(singlton);
                        }
                    }
                    return _instance;
                }
                
            }
        }

        protected virtual void OnDestroy()
        {
            isApplicationQuitting = true;
        }

    }
}


