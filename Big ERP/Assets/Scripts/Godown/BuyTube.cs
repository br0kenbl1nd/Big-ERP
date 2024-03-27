using UnityEngine;
using UnityEngine.UI;

public class BuyTube : MonoBehaviour
{
    private GodownInventory godownInventory;

    private void Awake()
    {
        godownInventory = GetComponent<GodownInventory>();
    } //awake

    /// <summary>
    /// Purchase a tube and update stock using code number of the tube and quantity
    /// </summary>
    public void Buy_Tube(string _tube_code, float _qty)
    {
        godownInventory.AddStock(_tube_code, _qty);
        godownInventory.PrintReport();
    } //purchase tube

} //class
