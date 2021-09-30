using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_MANAGER : MonoBehaviour
{
    public Animator state;
    public Text TXT_MoneyPlayer;
    public GameObject[] SwitchOff;
    private void Start()
    {
        state = GetComponent<Animator>();
    }
    public void Ativar(int tempo)
    {
        if (state.GetBool("active"))
            {
            state.SetBool("active", false);
            
            }
            else
            {
                state.SetBool("active", true);
              
            }
        StartCoroutine(ResetShop());
    }

    public void SetStateShop(GameObject panel)
    {
        panel.SetActive(true);
        SwitchOff[0].SetActive(false);
        GameObject.FindWithTag("Card").GetComponent<OUTFIT_CHANGER>().SetState();
        Debug.Log("teste");
    }

    IEnumerator ResetShop()
    {
        yield return new WaitForSeconds(2);
        SwitchOff[0].SetActive(true);
        SwitchOff[1].SetActive(false);
        SwitchOff[2].SetActive(false);
    }
}
