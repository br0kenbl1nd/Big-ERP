using UnityEngine;
using UnityEngine.UI;

public class BuyTube : MonoBehaviour
{
    private GodownInventory godownInventory;

    public Dropdown godownTubeSizeDropDownUI;
    public InputField godownBuyTubeQtyUI;

    private string selectedTubeCode;
    private float selectedTubeQty;

    private void Awake()
    {
        godownInventory = GetComponent<GodownInventory>();
    } //awake

    private void Start()
    {
        godownTubeSizeDropDownUI.onValueChanged.AddListener(OnTubeSizeInput);
        godownBuyTubeQtyUI.onValueChanged.AddListener(OnTubeQtyInput);
    } //start

    /// <summary>
    /// Set qty of tube to be added
    /// </summary>
    public void SetTubeQty(string _qty)
    {
        selectedTubeQty = float.Parse(_qty);
    } //set tube qty

    /// <summary>
    /// Purchase a tube and update stock using code number of the tube and quantity
    /// </summary>
    public void Buy_Tube()
    {
        godownInventory.AddStock(selectedTubeCode, selectedTubeQty);
        godownInventory.PrintReport();
    } //purchase tube

    void OnTubeSizeInput(int newIndex)
    {
        selectedTubeCode = godownTubeSizeDropDownUI.options[newIndex].text;
    } //On changing of drop down value

    public void OnTubeQtyInput(string _value)
    {
        selectedTubeQty = float.Parse(_value);
    } // On inputing the qty of tubes needed

} //class
