using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class MapCreator : MonoBehaviour
{
    int[,] map;
    private int X;
    private int Y;
    public GameObject mapBlock;
    public GameObject coverBlock;
    public TextAsset mapData;
    public float objectScale = 0.2F;
    public GameObject mapObj;
    // Start is called before the first frame update
    void Start()
    {
        if(mapObj == null){
            mapObj = this.gameObject;
        }
        FileReader();
    }

    void FileReader()
    {
        StringReader reader = new StringReader(mapData.text);
        string xy = reader.ReadLine();
        X = int.Parse(xy.Split(',')[0]);
        Y = int.Parse(xy.Split(',')[1]);
        map = new int[X,Y];
        int count=0;
        
        while(reader.Peek() != -1){
            //EOFまで読み込み
            string line = reader.ReadLine();
            Debug.Log(line);
            var lines = line.Split(',');
            for (int i=0;i<X;i++){
                map[i,count] = int.Parse(lines[i]);
            }
            count++;
        }
        for(int y=0;y<Y;y++){
            for(int x=0;x<X;x++){
                GameObject block = mapBlock;
                block.transform.localScale = new Vector3(1,map[x,y] * objectScale,1);
                GameObject cover = coverBlock;
                cover.transform.localScale = new Vector3(1,objectScale,1);
                GameObject bl = Instantiate(block, new Vector3((float)x, objectScale * map[x, y] / 2.0f, (float)y), Quaternion.identity);
                GameObject co = Instantiate(cover,new Vector3((float)x,objectScale*(map[x,y]+0.5f),(float)y),Quaternion.identity);
                bl.transform.parent = mapObj.transform;
                co.transform.parent = mapObj.transform;
            }                
        }
        Debug.Log(map);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
