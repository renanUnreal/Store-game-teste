using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OUTFIT_CHANGER : MonoBehaviour
{
    [Header("Sprite to change")]
    public Image[] bodyPartPrevils;
    public GameObject[] PlayerBodyPart;
    public int Price;
    public Text TxtItemPrice;
    public Button Confirm;
    public Button Cancel;
    public GameObject NoMoney;
    public Image cardImage;
    public GameObject Check;
    public bool Buy;
    public Sprite[] option;
    private bool cell = false;
    private void Awake()
    {
        cardImage.sprite = option[0];
        TxtItemPrice.text = Price.ToString();
    }

    private void Start()
    { 
        if (Buy)
        {
            if (Player_Infos.Money >= Price)
            {
                NoMoney.SetActive(false);
            }
        }
        else
        {
            NoMoney.SetActive(false);
        }

    }
    public void ChangeRoupa()
    {
        if (Buy)
        {
            if (Player_Infos.Money >= Price)
            {
                Confirm.gameObject.SetActive(true);
                Cancel.gameObject.SetActive(true);
                for (int i = 0; i < bodyPartPrevils.Length; i++)
                {
                    bodyPartPrevils[i].sprite = option[i];

                }
            }
        }
        else
        {
            Confirm.gameObject.SetActive(true);
            Cancel.gameObject.SetActive(true);
        }
    }

    public void ConfirmItem()
    {
        if (Buy)
        {
            for (int i = 0; i < PlayerBodyPart.Length; i++)
            {
                PlayerBodyPart[i].gameObject.GetComponent<SpriteRenderer>().sprite = option[i];
            }
            Player_Infos.Money -= Price;
            Confirm.gameObject.SetActive(false);
            Cancel.gameObject.SetActive(false);
            cell = true;
            foreach(GameObject teste in GameObject.FindGameObjectsWithTag("Card"))
            {
               teste.GetComponent<OUTFIT_CHANGER>().SetState();
            }
            Check.SetActive(true);
           
        }
        else
        {
            Player_Infos.Money += Price;
        }
            GameObject.FindWithTag("UI_Shop").GetComponent<UI_MANAGER>().TXT_MoneyPlayer.text = Player_Infos.Money.ToString();
            GameObject.FindWithTag("UI_Player").GetComponent<Item>().TXT_Moedas.text = Player_Infos.Money.ToString();
    }
    public void CancelItem()
    {
        for (int i = 0; i < bodyPartPrevils.Length; i++)
        {
            bodyPartPrevils[i].sprite = PlayerBodyPart[i].GetComponent<SpriteRenderer>().sprite;
        }
        Confirm.gameObject.SetActive(false);
        Cancel.gameObject.SetActive(false);
    }
    public void SetState()
    {
        if (!cell)
        {
            if (Buy)
            {
                if (Player_Infos.Money >= Price)
                {
                    NoMoney.SetActive(false);
                }
                else
                {
                    NoMoney.SetActive(true);
                }
            }
        }
    }
}
