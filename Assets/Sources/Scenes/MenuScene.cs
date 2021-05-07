using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
namespace WebStyleDemo.Scenes
{
    public class MenuScene : MonoBehaviour
    {
        [SerializeField] protected Button goToMainButton;

       // public DatosMainScene a;
        public string  placa;
        public string  fecha;
        public string  hora;
        public string dia1;
        public string dia2;
        public string diafecha;
        public bool checkHora;
        public Text Resultado;
        public Image UImage;

        private void Start()
        {
            placa = DatosMainScene.inputPlaca;
            fecha = DatosMainScene.inputFecha;
            hora = DatosMainScene.inputHora;
            Debug.Log("EN EL MENU PLACA ES "+placa);
            Debug.Log("EN EL MENU FECHA ES " + fecha);
            Debug.Log("EN EL MENU HORA ES " + hora);
            Debug.Log("MenuScene Start");
            UImage = GameObject.Find("ImagenCambiante").GetComponent<Image>();
            goToMainButton.onClick.AddListener(OnGoToMainButtonClicked);
            Verificacion(placa, fecha, hora);
        }

        private void OnDestroy()
        {
            Debug.Log("MenuScene OnDestroy");
            goToMainButton.onClick.RemoveListener(OnGoToMainButtonClicked);
        }
                 
        private void OnGoToMainButtonClicked()
        {
            SceneManager.LoadScene("MainScene");
        }

        public void Verificacion(string placa,string fecha,string hora)
        {        
            
            placa = placa.Substring(placa.Length - 1, 1);            
            Debug.Log("ultimo digito " + placa);
            int valor = Int32.Parse(placa);
            switch (valor)
            {
                case 0:
                    dia1 = "Lunes";
                    dia2 = "Viernes";
                    break;
                case 1:
                    dia1 = "Lunes";
                    dia2 = "Viernes";
                    break;
                case 2:
                    dia1 = "Lunes";
                    dia2 = "Martes";
                    break;
                case 3:
                    dia1 = "Lunes";
                    dia2 = "Martes";
                    break;
                case 4:
                    dia1 = "Martes";
                    dia2 = "Miercoles";
                    break;
                case 5:
                    dia1 = "Martes";
                    dia2 = "Miercoles";
                    break;
                case 6:
                    dia1 = "Miercoles";
                    dia2 = "Jueves";
                    break;
                case 7:
                    dia1 = "Miercoles";
                    dia2 = "Jueves";
                    break;
                case 8:
                    dia1 = "Jueves";
                    dia2 = "Viernes";
                    break;
                case 9:
                    dia1 = "Jueves";
                    dia2 = "Viernes";
                    break;
            }
            Debug.Log("Dias de circulacion" + dia1+"y"+dia2);

            DateTime dianombre = Convert.ToDateTime(fecha);
            byte dianombrebyte = (byte)dianombre.DayOfWeek;
            switch (dianombrebyte)
            {
                case 1:
                    diafecha = "Lunes";                   
                    break;
                case 2:
                    diafecha = "Martes";
                    break;
                case 3:
                    diafecha = "Miercoles";
                    break;
                case 4:
                    diafecha = "Jueves";
                    break;
                case 5:
                    diafecha = "Viernes";
                    break;
                case 6:
                    diafecha = "Sabado";
                    break;
                case 0:
                    diafecha = "Domingo";
                    break;
            }
            Debug.Log("Dia de la fecha" + diafecha);
            
            string horaverificacion = hora + ":00";
            var result = Convert.ToDateTime(horaverificacion);
            Int32 horaconvercion = result.Hour;
            if (horaconvercion > 6 && horaconvercion< 20 )
            {
                checkHora = true;
            }
            else
            {
                checkHora = false;
            }

            Debug.Log("Hora conversion" + horaconvercion+"checkhora"+ checkHora);

            if (((diafecha==dia1 || diafecha==dia2)&& checkHora==true)|| ((diafecha == "Sabado" || diafecha == "Domingo") && checkHora == true))
            {
                Resultado.text = "Si puede circular";
                UImage.sprite = Resources.Load<Sprite>("Images/HOYCIRCULA");
                Debug.Log("Si puede circular" );

            }
            else
            {
                Resultado.text = "No puede circular";
                UImage.sprite = Resources.Load<Sprite>("Images/HOYNOCIRCULA");
                Debug.Log("No puede circular" );
            }
        }

    }
}