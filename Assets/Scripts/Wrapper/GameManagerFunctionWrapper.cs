using UnityEngine;

public static class GameManagerFunctionWrapper
{

    public static void StartGame()
    {
        FactoryManager.Instance.PreIntilizationMethod();
        ObjectPool.PreInitializeMethod();
        CollisionSystem.Instance.PreIntilizationMethod();
        PlayerController.Instance.PreIntilizationMethod();
        BulletManager.Instance.PreIntilizationMethod();
        UnitManager.Instance.PreIntilizationMethod();
    }

    public static void InitializeGame() => PlayerController.Instance.InitializationMethod();

    public static void UpdateMethod()
    {
        PlayerController.Instance.UpdateMethod();
        CollisionSystem.Instance.UpdateMethod();
        BulletManager.Instance.UpdateMethod();
        UnitManager.Instance.UpdateMethod();
    }
}
