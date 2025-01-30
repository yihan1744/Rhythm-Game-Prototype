using UnityEngine;

public class PersistentObjectHandler : MonoBehaviour
{
    private static PersistentObjectHandler _instance;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
