using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CALL_SHOP : MonoBehaviour
{
    public Animator Anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "PLAYER")
        {
            Anim.SetBool("active", true);
            GameObject.FindWithTag("UI_Shop").GetComponent<UI_MANAGER>().TXT_MoneyPlayer.text = Player_Infos.Money.ToString();
        }
    }
}
