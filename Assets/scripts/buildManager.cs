using UnityEngine;
using System.Collections;

public class buildManager : MonoBehaviour {

    public static buildManager instance;
    public nodeUI nodeUI;

    void Awake()
    {
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject advanceTurretPrefab;
    public GameObject overpowerTurretPrefab;

    private turretBlueprint turretToBuild;
    private Node selectedNode;

	public bool CanBuild
    {
        get { return turretToBuild != null; }
    }

    public bool HaveMoney
    {
        get { return playerState.Money >= turretToBuild.cost; }
    }

    public void SelectNode(Node node)
    {
        if(selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    } 

    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }

	public void SelectTurretToBuild(turretBlueprint turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }

    public turretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}
