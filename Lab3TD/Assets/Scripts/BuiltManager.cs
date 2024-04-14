using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltManager : MonoBehaviour
{
    public static BuiltManager main;

    [Header("References")]
    //[SerializeField] private GameObject[] towerPrefabs;
    [SerializeField] private TowerScript[] towers;

    private int selectedTower = 0;

    private void Awake()
    {
        main = this;
    }

    public TowerScript GetSelectredTower()
    {
        return towers[selectedTower];
    }

    public void SetSelectredTower(int _selectedTower)
    {
        selectedTower = _selectedTower;
    }
}
