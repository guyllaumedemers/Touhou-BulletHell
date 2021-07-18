using UnityEngine;
using UnityEngine.SceneManagement;

public class EntryPoint : SingletonMono<EntryPoint>
{
    private EntryPoint() { }
    public float Last { get; private set; }

    public void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            UIManager.Instance.PreIntilizationMethod();
            return;
        }
        GameManagerIntermediate.StartGame();
        Last = default;
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            return;
        }
        StartCoroutine(ObjectPool.Trim());
        GameManagerIntermediate.InitializeGame();
        StartCoroutine(Utilities.Timer(Globals.waveInterval, () => { StartCoroutine(WaveSystem.Instance.InitializationMethod()); }));
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            return;
        }
        if (Time.time - Last > Globals.fps)
        {
            GameManagerIntermediate.UpdateMethod();
            Last = Time.time;
        }
    }
}
