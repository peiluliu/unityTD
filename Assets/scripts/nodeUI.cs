using UnityEngine;
using System.Collections;

public class nodeUI : MonoBehaviour {
    public GameObject ui;

    private Node target;
    
    public void SetTarget(Node _target)
    {
        this.target = _target;

        transform.position = target.GetBuildPosition();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Selling()
    {
        target.SellTurret();
        buildManager.instance.DeselectNode();
    }
}
