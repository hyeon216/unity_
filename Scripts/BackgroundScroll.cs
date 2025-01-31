using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [Header("Settings")]    //��ũ�ѽ��ǵ����� ǥ�õ�
    [Tooltip("How fast should the texture scroll?")]  //���콺���ٴ����� ǥ������
    public float scrollSpeed;

    [Header("References")]
    public MeshRenderer meshRenderer;   
    //��ũ��Ʈ�� meshRenderer���� (meshRenderer�� ���ٰ����ϰ�)
    ///�Ŀ� ��ũ��Ʈ������Ʈ�� �ش�ĭ�� Mesh Renderer�巡��
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   //�ʴ� 10���� �����̰� ///�ʴ� 2������
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed*Time.deltaTime, 0);
        //Time.deltaTime�� ���������ν� 1�ʿ� �ѹ��� �̵��ϰ� ����
    }
}
