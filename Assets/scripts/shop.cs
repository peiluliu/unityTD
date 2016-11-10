using UnityEngine;
using System.Collections;

public class shop : MonoBehaviour {

    buildManager buildManager;
    public turretBlueprint standardTurret;
    public turretBlueprint advanceTurret;
    public turretBlueprint overpowerTurret;

    void Start()
    {
        buildManager = buildManager.instance;
    }

    public void SelectStandardTurret()
    {
        buildManager.SelectTurretToBuild(standardTurret);
        
    }

    public void SelectAdvanceTurret()
    {
        buildManager.SelectTurretToBuild(advanceTurret);
    }

    public void SelectOverPowerTurret()
    {
        buildManager.SelectTurretToBuild(overpowerTurret);
    }
    
}
