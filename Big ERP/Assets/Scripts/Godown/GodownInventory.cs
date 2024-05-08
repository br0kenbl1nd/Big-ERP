using UnityEngine;
using System.Collections.Generic;

public class GodownInventory : MonoBehaviour
{
    public GodownUI godownUI;

    public List<EmptyTubeBP> emptyTubes = new List<EmptyTubeBP>();

    //Contains functions to print report, add a new size of the tube, updates stock of a particular tube
    #region Inventory Functions
    //display all the stock available in the godown
    public void PrintReport()
    {
        for(int i = 0; i < emptyTubes.Count; i++)
        {
            Debug.Log(emptyTubes[i].Size);
            Debug.Log(emptyTubes[i].qty);
        }
    } //print report


    // add a new size of inner tube
    public void AddNewSizeTube(EmptyTubeBP _emptyTubeBP)
    {
        if(!CheckIfTubeSizeExists(_emptyTubeBP.Size))
        {
            emptyTubes.Add(_emptyTubeBP);
            godownUI.UpdateTubeSizeList();
        }
        Debug.Log("Tube size already exists");
    } // Add new size small tube


    /// <summary>
    /// Returns whether the passed empty tube stock is available or not
    /// </summary>
    public bool CheckStock(string code_no, float qtyRqd)
    {
        foreach(EmptyTubeBP smallTube in emptyTubes)
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
        foreach(EmptyTubeBP smalltube in emptyTubes)
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
        foreach (EmptyTubeBP smalltube in emptyTubes)
        {
            if (smalltube.CodeNo == _codeNo)
            {
                smalltube.qty += qty;
            }
        }
    } // UpdateStock

    bool CheckIfTubeSizeExists(string _size)
    {
        foreach(EmptyTubeBP _emptyTube in emptyTubes)
        {
            if(_size == _emptyTube.Size)
            {
                return true;
            }
        }

        return false;

    } //check if tube size exists

    #endregion


} //class
