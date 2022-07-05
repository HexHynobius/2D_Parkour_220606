
using UnityEngine;

namespace hyno
{
    public class ManagerPass : MonoBehaviour
    {

        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "Runer";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("�ؼЦW��")]
        private SystemJump systemJump;
        [SerializeField, Header("�e��")]
        private ManagerFinal managerFinal;


        #region
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name);

            if(collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false;
                systemJump.enabled = false;

                managerFinal.enabled = true;
                managerFinal.stringTitle = "���߹L��";
            }

        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion

        #region
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
        #endregion
    }

}

