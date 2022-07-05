using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace hyno
{
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("畫布")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("遊戲結束標題")]
        private TextMeshProUGUI textFinal;
        
        /// <summary>
        /// 遊戲結束標題文字內容
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;

            InvokeRepeating("FadeIn", 0, 0.1f);
        }



        /// <summary>
        /// 淡入
        /// </summary>
        private void FadeIn()
        {
            groupFinal.alpha += 0.1f;


            if(groupFinal.alpha>=1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }
        }
        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void Quit()
        {
            print("離開遊戲");
            Application.Quit();
        }


        public void Replay()
        {
            SceneManager.LoadScene(0);
        }
    }

}


