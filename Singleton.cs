using UnityEngine;

namespace Karan.Util
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T ms_instance;

        public static T Instance
        {
            get
            {
                if (ms_instance == null)
                {
                    ms_instance = FindObjectOfType<T>();

                    if (ms_instance == null)
                    {
                        var go = new GameObject();

                        go.name = nameof(T);
                        ms_instance = go.AddComponent<T>();
                    }
                }

                return ms_instance;
            }
        }

        public virtual void Awake()
        {
            if (ms_instance == null)
            {
                ms_instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
                Destroy(gameObject);
        }
    }
}