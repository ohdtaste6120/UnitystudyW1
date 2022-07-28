using UnityEngine;
using UnityEngine.UI;

public class Switching : MonoBehaviour
{
    public Image buttonImage;
    public Sprite[] buttonSprite;

    public bool state; // 이렇게 두면 false 상태
    
    public void Behaviour()
    {
        state = !state;

        if (state)
        {
            Time.timeScale = 0; // 게임 속 시간이 0으로 일시정지
            buttonImage.sprite = buttonSprite[0];
        }

        else
        {
            Time.timeScale = 1;
            buttonImage.sprite = buttonSprite[1];
        }
    }
}
