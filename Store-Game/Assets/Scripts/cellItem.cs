using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cellItem : MonoBehaviour
{
    [Header("Sprite to change")]
    public int Price;
    public Text TxtItemPrice;
    public Button Confirm;
    public Button Cancel;
    public Image cardImage;
    public Sprite CardIcon;
    private void Awake()
    {
        TxtItemPrice.text = Price.ToString();
        cardImage.sprite = CardIcon;
    }
    
    public void ChangeRoupa()
    {
       Confirm.gameObject.SetActive(true);
       Cancel.gameObject.SetActive(true);    
    }

    public void ConfirmItem()
    {
        Player_Infos.Money += Price;
       GameObject.FindWithTag("UI_Shop").GetComponent<UI_MANAGER>().TXT_MoneyPlayer.text = Player_Infos.Money.ToString();
       GameObject.FindWithTag("UI_Player").GetComponent<Item>().TXT_Moedas.text = Player_Infos.Money.ToString();
        Destroy(gameObject);
        
    }

    public void CancelItem()
    {
        Confirm.gameObject.SetActive(false);
        Cancel.gameObject.SetActive(false);
    }
}
