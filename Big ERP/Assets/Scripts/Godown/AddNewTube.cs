using UnityEngine;

[RequireComponent(typeof(GodownInventory))]
public class AddNewTube : MonoBehaviour
{

    private GodownInventory godownInventory;

    private void Awake()
    {
        godownInventory = GetComponent<GodownInventory>();
    } //Awake

    public void AddNewTubeSize(string _code_no, string _size, float _qty)
    {

        godownInventory.AddNewSizeTube(new EmptyTubeBP(_code_no, _size, _qty));

    } //add new tube size

} //class
