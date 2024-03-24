using UnityEngine;
using System.Collections.Generic;

public class GodownInventory : MonoBehaviour
{
    public GodownUI godownUI;

    public List<EmptyTubeBP> smallTubes = new List<EmptyTubeBP>();

    //Contains functions to print report, add a new size of the tube, updates stock of a particular tube
    #region Inventory Functions
    //display all the stock available in the godown
    public void PrintReport()
    {
        for(int i = 0; i < smallTubes.Count; i++)
        {
            Debug.Log(smallTubes[i].Size);
            Debug.Log(smallTubes[i].qty);
        }
    } //print report


    // add a new size of inner tube
    public void AddNewSizeTube(EmptyTubeBP _emptyTubeBP)
    {
        smallTubes.Add(_emptyTubeBP);
        godownUI.UpdateTubeSizeList();
    } // Add new size small tube


    /// <summary>
    /// Returns whether the passed empty tube stock is available or not
    /// </summary>
    public bool CheckStock(string code_no, float qtyRqd)
    {
        foreach(EmptyTubeBP smallTube in smallTubes)
        {
            if(smallTube.CodeNo == code_no)
            {
                if(smallTube.qty > qtyRqd)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return false;

    } //Check size

    /// <summary>
    /// Removes stock of empty tube using code number and qty
    /// </summary>
    public void RemoveStock(string _codeNo, float qty)
    {
        foreach(EmptyTubeBP smalltube in smallTubes)
        {
            if(smalltube.CodeNo == _codeNo)
            {
                smalltube.qty -= qty;
            }
        }
    } // UpdateStock

    /// <summary>
    /// Adds stock of empty tube using code number and qty 
    /// </summary>
    /// <param name="_codeNo"></param>
    /// <param name="qty"></param>
    public void AddStock(string _codeNo, float qty)
    {
        foreach (EmptyTubeBP smalltube in smallTubes)
        {
            if (smalltube.CodeNo == _codeNo)
            {
                smalltube.qty += qty;
            }
        }
    } // UpdateStock

    #endregion

    //UI based functions

} //class
