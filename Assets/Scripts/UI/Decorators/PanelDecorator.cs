using UnityEngine;

public abstract class PanelDecorator : IGraphicComponent
{
    public PanelComponent panelInstance { get; private set; }

    protected virtual void Awake()
    {
        panelInstance = GetComponent<PanelComponent>();
        if (!panelInstance)
        {
            LogWarning($"There is no panelComponent script attach to this gameobject {gameObject.name}");
            return;
        }
    }

    #region public functions

    public override void PlayGraphicAnimation()
    {
        panelInstance.PlayGraphicAnimation();
    }

    #endregion

    #region  private functions

    private void LogWarning(string msg) => Debug.LogWarning("[Panel Decorator] : " + msg);

    #endregion
}
