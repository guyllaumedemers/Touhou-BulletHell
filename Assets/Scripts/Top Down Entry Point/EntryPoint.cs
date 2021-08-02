using UnityEngine;
using UnityEngine.SceneManagement;

public class EntryPoint : SingletonMonoPersistent<EntryPoint>
{
    private EntryPoint() { }
    public float Last { get; private set; }

    private int curr_scene = (int)SceneEnum.TitleScreen;

    public override void Awake()
    {
        base.Awake();
        LoadScene(curr_scene);
    }

    #region public functions

    public void TriggerNextScene() => LoadScene(++curr_scene);

    public void TriggerPreviousScene() => LoadScene(--curr_scene);

    #endregion


    #region private functions

    private void LoadScene(int index, int last = 0)
    {
        if (index < 0)
        {
            LogWarning("Scene Index invalid");
            return;
        }
        else if (last != 0 && last > 0)
        {
            SceneManager.UnloadSceneAsync(last);
        }
        SceneManager.LoadSceneAsync(index);
    }

    private void LogWarning(string msg) => Debug.LogWarning("[EntryPoint] : " + msg);

    #endregion
}
