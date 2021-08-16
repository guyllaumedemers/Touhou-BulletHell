using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlinkingTextDecorator : ButtonDecorator
{
    #region public functions

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        if (!buttonInstance.button.interactable)
        {
            LogWarning("button interactable is set to false");
            return;
        }
        PlayGraphicAnimation();
    }

    public override void PlayGraphicAnimation()
    {
        base.PlayGraphicAnimation();
        Blinkingtext();
    }

    #endregion

    #region private function

    private void Blinkingtext()
    {
        StopCoroutine(typeof(CustomDotTween).GetMethods().Where(x => x.Name == "BlinkingTextUI").FirstOrDefault().Name);
        StartCoroutine(CustomDotTween.BlinkingTextUI(buttonInstance.text, Globals.blinkingTime, 5));
    }

    private void LogWarning(string msg) => Debug.LogWarning("[Blinking Text Decorator] : " + msg);

    #endregion
}
