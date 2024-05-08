using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodownUI : MonoBehaviour
{
    public GodownInventory godownInventory;

    [Header("Add Tube Stock")]
    public BuyTube buyTube;

    public Dropdown godownTubeSizeDropDownUI;
    public InputField godownBuyTubeQtyUI;

    private string selectedTubeCode;
    private float selectedTubeQty;

    public GameObject addTubeStockPopUp;

    [Header("Add new size tube")]
    public AddNewTube addNewTube;

    public InputField newTubeCodeInput;
    public InputField newTubeSizeInput;
    public InputField newTubeQtyInput;

    private string newTubeCode;
    private string newTubeSize;
    private float newTubeQty;

    public GameObject addNewTubeSizePopUp;

    private void Start()
    {
        UpdateTubeSizeList();

        //UI listeners for add tube stock
        godownTubeSizeDropDownUI.onValueChanged.AddListener(OnTubeSizeInput);
        godownBuyTubeQtyUI.onValueChanged.AddListener(OnTubeQtyInput);

        //UI listeners for add new tube size
        newTubeCodeInput.onValueChanged.AddListener(OnNewTubeCodeInput);
        newTubeSizeInput.onValueChanged.AddListener(OnNewTubeSizeInput);
        newTubeQtyInput.onValueChanged.AddListener(OnNewTubeQtyInput);

    }

    #region Add Tube stock 
    public void UpdateTubeSizeList()
    {
        godownTubeSizeDropDownUI.ClearOptions();

        List<string> list_of_tubes = new List<string>();

        list_of_tubes.Add("None");

        foreach (EmptyTubeBP emptyTube in godownInventory.emptyTubes)
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
        DisableAddTubeStockPopUp();
    } //add tube stock

    #endregion

    #region Add new Tube size

    public void OnNewTubeCodeInput(string _value)
    {
        newTubeCode = _value;
    }

    public void OnNewTubeSizeInput(string _value)
    {
        newTubeSize = _value;
    }

    public void OnNewTubeQtyInput(string _value)
    {
        newTubeQty = float.Parse(_value);
    }

    public void AddNewTubeSize()
    {
        addNewTube.AddNewTubeSize(newTubeCode, newTubeSize, newTubeQty);
        DisableAddNewTubeSizePopUp();
    } //add new tube size

    #endregion

    #region UI elements manipulation
    public void EnableAddTubeStockPopUp()
    {
        addTubeStockPopUp.SetActive(true);

        godownTubeSizeDropDownUI.value = 0;

        godownBuyTubeQtyUI.text = "0";

    } //enable add tube stock pop up

    public void DisableAddTubeStockPopUp()
    {
        addTubeStockPopUp.SetActive(false);
    } //enable add tube stock pop up   

    public void EnableAddNewTubeSizePopUp()
    {
        addNewTubeSizePopUp.SetActive(true);
    } //enable add new tube size pop up

    public void DisableAddNewTubeSizePopUp()
    {
        addNewTubeSizePopUp.SetActive(false);
    } //enable add new tube size pop up

    #endregion

} //class
