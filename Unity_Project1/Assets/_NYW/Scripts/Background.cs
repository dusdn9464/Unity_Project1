using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //public MeshRenderer backGround;
    //float speed = 0.01f;
    //Vector2 offset = Vector2.zero;

    Material mat;
    public float scrollSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //backGround = GetComponent<MeshRenderer>();

        //메테리얼은 렌더러 컴포넌트안에 속성으로 붙어 있다
        mat = GetComponent<MeshRenderer>().material;
        //mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        BackgroundScroll();
        //offset.y += speed;
        //backGround.material.SetTextureOffset("_MainTex", offset);
    }

    //백그라운드 스크롤
    private void BackgroundScroll()
    {
        //아래와 같은걸 캐스팅이라고 한다
        //transform.position 조정할때 방법과 동일하다

        //메테리얼의 메인텍스쳐 오프셋은 Vector2로 만들어져 있다
        Vector2 offset = mat.mainTextureOffset;
        //offset.y 의 값만 보정해주면 된다
        //offset.y += scrollSpeed * Time.deltaTime;
        offset.Set(0, offset.y + scrollSpeed * Time.deltaTime);
        //다시 메테리얼 오프셋에 담는다
        mat.mainTextureOffset = offset;

    }
}
