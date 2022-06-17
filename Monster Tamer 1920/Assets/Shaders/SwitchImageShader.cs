using UnityEngine;
using UnityEngine.UI;

public class SwitchImageShader : MonoBehaviour
{
    // Toggle between sprite lit and grayscale shaders
    // when space key is pressed

    Shader shader1;
    Shader shader2;
    Image rend;
    Material startingMaterial;
    Material material1;
    Material material2;


    void Start()
    {
        rend = GetComponent<Image>();
        shader1 = Shader.Find("Universal Render Pipeline/2D/Sprite-Lit-Default");
        shader2 = Shader.Find("Sprites-GrayScale");
     //   startingMaterial = GetComponent<Material>();
     //   material1 = startingMaterial;
       // material2 = rend.material.("Sprites-Default");
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
            //    rend.material = material1;
            }
        }
    }
}