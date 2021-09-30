using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int Value;
    public Text TXT_Moedas;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("PLAYER"))
        {
            collision.gameObject.GetComponent<Player_Infos>().ChangeMoney(Value);
            collision.gameObject.GetComponent<Player_Infos>().ChangeTextUI(TXT_Moedas);
            Destroy(gameObject);
        }
    }
}
