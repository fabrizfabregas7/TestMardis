using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace WebStyleDemo.Scenes
{
    public class MainScene : MonoBehaviour
    {
        // SCENE REFERENCES HERE: attached from Unity Editor
        [SerializeField] protected Button goToMenuButton;
       // public string inputPlaca;
        //public string inputFecha;
        //public string inputHora;

        /// <summary>
        /// Adds events
        /// </summary>
        private void Start()
        {
            Debug.Log("MainScene Start");

            goToMenuButton.onClick.AddListener(OnGoToMenuButtonClicked);
        }

        /// <summary>
        /// Removes listeners
        /// </summary>
       /* private void OnDestroy()
        {
            Debug.Log("MainScene OnDestroy");

            goToMenuButton.onClick.RemoveListener(OnGoToMenuButtonClicked);
        }
       */
        private void OnGoToMenuButtonClicked()
        {

            SceneManager.LoadScene("MenuScene");

        }
        /*
        public void ReadPlaca(string a) {
            inputPlaca = a;
            Debug.Log(inputPlaca);
        }
        public void ReadFecha(string b)
        {
            inputFecha = b;
            Debug.Log(inputFecha);
        }
        public void ReadHora(string c)
        {
            inputHora = c;
            Debug.Log(inputHora);
        }
        */
    }
}