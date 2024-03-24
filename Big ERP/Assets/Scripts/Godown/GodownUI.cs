using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodownUI : MonoBehaviour
{
    public GodownInventory godownInventory;
    public BuyTube buyTube;

    public Dropdown godownTubeSizeDropDownUI;
    public InputField godownBuyTubeQtyUI;

    private string selectedTubeCode;
    private float selectedTubeQty;

    public GameObject addTubeStockPopUp;

    private void Start()
    {
        UpdateTubeSizeList();
        godownTubeSizeDropDownUI.onValueChanged.AddListener(OnTubeSizeInput);
        godownBuyTubeQtyUI.onValueChanged.AddListener(OnTubeQtyInput);
    }

    #region Add Tube stock 
    public void UpdateTubeSizeList()
    {
        godownTubeSizeDropDownUI.ClearOptions();

        List<string> list_of_tubes = new List<string>();

        list_of_tubes.Add("None");

        foreach (EmptyTubeBP emptyTube in godownInventory.smallTubes)
        {
            list_of_tubes.Add(emptyTube.CodeNo);
        }

        godownTubeSizeDropDownUI.AddOptions(list_of_tubes);

    }

    public void OnTubeSizeInput(int newIndex)
    {
        selectedTubeCode = godownTubeSizeDropDownUI.options[newIndex].text;
    } //On changing of drop down value

    public void OnTubeQtyInput(string _value)
    {
        selectedTubeQty = float.Parse(_value);
    } // On inputing the qty of tubes needed

    public void AddTubeStock()
    {
        buyTube.Buy_Tube(selectedTubeCode, selectedTubeQty);
    } //add tube stock

    #endregion

    #region UI elements manipulation
    public void EnableAddTubeStockPopUp()
    {
        addTubeStockPopUp.SetActive(true);
    } //enable add tube stock pop up

    public void DisableAddTubeStockPopUp()
    {
        addTubeStockPopUp.SetActive(false);
    } //enable add tube stock pop up
    #endregion

} //class
