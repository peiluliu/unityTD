using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {
    public Color hoverColor;
    public Vector3 positionoffset;
    public Color notEnoughMoneyColor;

    
    private Renderer rend;
    private Color startColor;

    [Header("Optional")]
    public GameObject turret;
    public turretBlueprint turretblueprint;
    buildManager BM;


    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        BM = buildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionoffset;
    }

    void OnMouseDown()
    {

        if (EventSystem.current.IsPointerOverGameObject())
            return;


        if(turret != null)
        {
            BM.SelectNode(this);
            return;
        }

        if (!BM.CanBuild)
            return;
        
        BuildTurret(BM.GetTurretToBuild());
    }

    void BuildTurret(turretBlueprint blueprint)
    {
        if (playerState.Money < blueprint.cost)
        {
            Debug.Log("Not enought money");
            return;
        }

        playerState.Money -= blueprint.cost;

        GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;
        turretblueprint = blueprint;
    }

    public void SellTurret()
    {
        playerState.Money += turretblueprint.sellcost;
        Destroy(turret);
    }
    void OnMouseEnter()
    {
        if (!BM.CanBuild)
            return;

        if (BM.HaveMoney)
        {
            GetComponent<Renderer>().material.color = hoverColor;

        }
        else
        {
            GetComponent<Renderer>().material.color = notEnoughMoneyColor;
        }

        


    }

    void OnMouseExit()
    {

        rend.material.color = startColor;
    }

}
