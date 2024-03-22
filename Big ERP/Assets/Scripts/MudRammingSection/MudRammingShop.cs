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

    /// <summary>
    /// Add the qty to the mud filled stock
    /// </summary>
    public void AddStock(string _codeNo, float qty)
    {
        foreach(MudFilledTube _mudFilledTube in mudFilledTubes)
        {
            if(_mudFilledTube.CodeNo == _codeNo)
            {
                _mudFilledTube.qty += qty;  
            }
        }
    } //update stock

    /// <summary>
    /// Remove the qty to the mud filled stock
    /// </summary>
    public void RemoveStock(string _codeNo, float qty)
    {
        foreach (MudFilledTube _mudFilledTube in mudFilledTubes)
        {
            if (_mudFilledTube.CodeNo == _codeNo)
            {
                _mudFilledTube.qty -= qty;
            }
        }
    } //update stock


    #endregion


} //class
