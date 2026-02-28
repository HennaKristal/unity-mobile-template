using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }
    protected bool IsSingletonInstance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            IsSingletonInstance = false;
            return;
        }

        Instance = this as T;
        IsSingletonInstance = true;
    }

    protected virtual void OnApplicationQuit()
    {
        Instance = null;
    }
}
