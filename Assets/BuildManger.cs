﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManger : MonoBehaviour {

    public static BuildManger instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BM in Scene");
            return;
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;

    void Start()
    {
        turretToBuild = standardTurretPrefab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }
}
