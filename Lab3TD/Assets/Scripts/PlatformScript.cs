using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlatformScript : MonoBehaviour
{


    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

    private GameObject towerObject;
    public TurretScript turret;
    private Color startColor;

    private void Start()
    {
        startColor = sr.color;
    }

    private void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown()
    {
        //if (UIManagerScript.main.IsHoveringUI()) return;

        if (towerObject != null)
        {
            turret.OpenUpgradeUI();
            return;
        }

        TowerScript towerToBuilt = BuiltManager.main.GetSelectredTower();

        if (towerToBuilt.cost > GameManager.main.currency)
        {
            Debug.Log("you can not afford this tower");
            return;
        }

        GameManager.main.SpendCurrency(towerToBuilt.cost);

        towerObject = Instantiate(towerToBuilt.prefab, transform.position, Quaternion.identity);
        turret = towerObject.GetComponent<TurretScript>();
    }
}
