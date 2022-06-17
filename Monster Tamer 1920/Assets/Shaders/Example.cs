using UnityEngine;

public class Example : MonoBehaviour
{
    // Toggle between Diffuse and Transparent/Diffuse shaders
    // when space key is pressed

    Shader shader1;
    Shader shader2;
    Renderer rend;


    void Start()
    {
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("Universal Render Pipeline/2D/Sprite-Lit-Default");
        shader2 = Shader.Find("Sprites-GrayScale");
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (rend.material.shader == shader1)
            {
                rend.material.shader = shader2;
            }
            else
            {
                rend.material.shader = shader1;
            }
        }
    }
}