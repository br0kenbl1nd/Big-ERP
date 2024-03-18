using UnityEngine;
using System.Collections.Generic;

public class GodownInventory : MonoBehaviour
{

    [SerializeField] private List<EmptyTubeBP> smallTubes = new List<EmptyTubeBP>();


    private void Start()
    {
        PrintReport();
    } //start


    //Contains functions to print report, add a new size of the tube, updates stock of a particular tube
    #region General Functions
    //display all the stock available in the godown
    public void PrintReport()
    {
        for(int i = 0; i < smallTubes.Count; i++)
        {
            Debug.Log(smallTubes[i].size);
        }
    } //print report


    // add a new size of inner tube
    public void AddNewSizeSmallTube(EmptyTubeBP _emptyTubeBP)
    {
        smallTubes.Add(_emptyTubeBP);
    } // Add new size small tube


    //updates stock of a tube size based on its code no
    public void UpdateStock(string _codeNo, float qty)
    {
        foreach(EmptyTubeBP smalltube in smallTubes)
        {
            if(smalltube.codeNo == _codeNo)
            {
                smalltube.qty -= qty;
            }
        }
    } // UpdateStock

    #endregion

} //class
