using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    //Cuando el usuario presione el btn aceptar
    //se debe escribir el mensaje en la consola
    //Si el texto de input password conicide con
    //la contraseña predeterminada escribir "access garanted"
    //sino escribir "access denied"    

    public InputField inputnombre; 
    public string contraseña;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void contra()
    {
        if (inputnombre.text == contraseña)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }

    }
}
