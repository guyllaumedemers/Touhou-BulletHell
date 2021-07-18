using UnityEngine;

public class EntryPoint : SingletonMono<EntryPoint>
{
    private EntryPoint() { }
    public float Last { get; private set; }

    private void Awake()
    {
        FactoryManager.Instance.PreIntilizationMethod();
        //WaypointSystem.Instance.PreIntilizationMethod();
        //WaveSystem.Instance.PreIntilizationMethod(default, (int)SpawningPosEnum.None, (int)SpawningPosEnum.Pivot, 4);
        //ObjectPool.PreInitializeMethod();
        //PlayerController.Instance.PreIntilizationMethod();
        //BulletManager.Instance.PreIntilizationMethod();
        //UnitManager.Instance.PreIntilizationMethod();
        UIManager.Instance.PreIntilizationMethod();
        Last = default;
    }

    private void Start()
    {
        //StartCoroutine(ObjectPool.Trim());
        //PlayerController.Instance.InitializationMethod();
        //StartCoroutine(Utilities.Timer(3.0f, () => { StartCoroutine(WaveSystem.Instance.InitializationMethod()); }));
    }

    private void Update()
    {
        //if (Time.time - Last > Globals.fps)
        //{
        //    PlayerController.Instance.UpdateMethod();
        //    CollisionSystem.Instance.UpdateMethod();
        //    BulletManager.Instance.UpdateMethod();
        //    UnitManager.Instance.UpdateMethod();
        //    Last = Time.time;
        //}
    }
}
