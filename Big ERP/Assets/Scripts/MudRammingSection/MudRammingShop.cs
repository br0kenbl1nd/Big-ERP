using UnityEngine;
using System.Collections.Generic;

public class MudRammingShop : MonoBehaviour
{
    public GodownInventory godownInventory;

    #region Inventory 
    //creating the structure

    [SerializeField] private List<MudFilledTube> mudFilledTubes = new List<MudFilledTube>();

    //print report of stock available mud filled tubes
    public void PrintReport()
    {
        foreach (MudFilledTube _mudfilledTube in mudFilledTubes)
        {
            print(_mudfilledTube.qty);
        }
    } //Print Report

    #endregion

    public void FillMud(string codeNo, float qty)
    {
        foreach(MudFilledTube _mudfilledTube in mudFilledTubes)
        {
            if(_mudfilledTube.codeNo == codeNo)
            {
                _mudfilledTube.qty += qty;
                godownInventory.UpdateStock(_mudfilledTube.rqdTubeCodeNo, qty);
            }
        }

    } //fill mud

} //class
