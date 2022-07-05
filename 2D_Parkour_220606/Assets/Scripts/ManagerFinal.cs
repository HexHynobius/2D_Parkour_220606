using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace hyno
{
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;
        
        /// <summary>
        /// �C���������D��r���e
        /// </summary>
        public string stringTitle;

        private void Start()
        {
            textFinal.text = stringTitle;

            InvokeRepeating("FadeIn", 0, 0.1f);
        }



        /// <summary>
        /// �H�J
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
        /// ���}�C��
        /// </summary>
        public void Quit()
        {
            print("���}�C��");
            Application.Quit();
        }


        public void Replay()
        {
            SceneManager.LoadScene(0);
        }
    }

}


