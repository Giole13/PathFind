using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapController : MonoBehaviour
{
    protected string tileMapObjName = default;
    protected MapBoard mapControler = default;
    protected Tilemap tileMap = default;
    protected List<GameObject> allTileObjs = default;

    //! Awake 타임에 초기화 할 내용을 상속받은 클래스별로 재정의 한다.
    public virtual void InitAwake(MapBoard mapControler_)
    {
        mapControler = mapControler_;
        tileMap = gameObject.FindChildComponent<Tilemap>(tileMapObjName);

        // 직사각형 형태로 초기화 된 타일을 캐싱해서 가지고 있는다.
        allTileObjs = tileMap.gameObject.GetChildrenObjs();
        if (allTileObjs.IsVaild())
        {
            allTileObjs.Sort(GioleFunc.CompareTileObjToLocalPos2D);
        }
        else { allTileObjs = new List<GameObject>(); }

        /* Todo */
    }       // InitAwake()

}       // Class TileMapController
