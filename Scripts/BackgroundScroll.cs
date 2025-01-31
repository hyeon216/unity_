using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [Header("Settings")]    //스크롤스피드위에 표시됨
    [Tooltip("How fast should the texture scroll?")]  //마우스갖다댔을때 표시해줌
    public float scrollSpeed;

    [Header("References")]
    public MeshRenderer meshRenderer;   
    //스크립트에 meshRenderer제공 (meshRenderer에 접근가능하게)
    ///후에 스크립트컨포넌트에 해당칸에 Mesh Renderer드래그
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   //초당 10단위 움직이게 ///초당 2프레임
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed*Time.deltaTime, 0);
        //Time.deltaTime을 곱해줌으로써 1초에 한번만 이동하게 만듦
    }
}
