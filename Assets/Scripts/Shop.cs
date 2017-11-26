using UnityEngine;

public class Shop : MonoBehaviour {

    BuildManger buildManager;

    void Start()
    {
        buildManager = BuildManger.instance;
    }
	public void PurchaseStandardTurret()
    {
        Debug.Log("Standard turret purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchaseAnotherTurret()
    {
        Debug.Log("second turret purchased");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
