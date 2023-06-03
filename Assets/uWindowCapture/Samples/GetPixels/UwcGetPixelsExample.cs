using UnityEngine;
using System.Collections.Generic;

public class UwcGetPixelsExample : MonoBehaviour
{
    [SerializeField] uWindowCapture.UwcWindowTexture uwcTexture;

    [SerializeField] int x = 100;
    [SerializeField] int y = 100;
    [SerializeField] int w = 64;
    [SerializeField] int h = 32;
    
    public Texture2D texture;
    Color32[] colors;


    private int pitchLeft = 152;
    private int pitchTop = 51;
    private int pitchWidth = 780;
    private int pitchHeight = 450;

    private int tileSize = 30;

    public GameObject player;

    public Material blueMaterial;

    public Material redMaterial;

    public Dictionary<Vector2Int, GameObject> playerMap;

    void CreateTextureIfNeeded()
    {
        if (!texture || texture.width != w || texture.height != h)
        {
            Debug.Log(w);
            Debug.Log(h);


            colors = new Color32[w * h];
            texture = new Texture2D(w, h, TextureFormat.RGBA32, false);
            GetComponent<Renderer>().material.mainTexture = texture;
        }
    }


    void CheckTiles()
    {
        //Debug.Log("checking tiles");

        for (int x = 0; x < 26; x++)
        {
            for (int y = 0; y < 15; y++)
            {
                Color32[] tilePixels = uwcTexture.window.GetPixels(pitchLeft + tileSize * x, pitchTop + tileSize * y, tileSize, tileSize);

                int avR = 0;
                int avG = 0;
                int avB = 0;

                foreach (Color32 tilePixel in tilePixels)
                {
                    avR += tilePixel.r;
                    avG += tilePixel.g;
                    avB += tilePixel.b;
                }

                avR /= tileSize * tileSize;
                avG /= tileSize * tileSize;
                avB /= tileSize * tileSize;

                //Debug.Log(avR);


                if (avR > 125 && !playerMap.ContainsKey(new Vector2Int(x, y)))
                {
                    playerMap[new Vector2Int(x, y)] = Instantiate(player, new Vector3(x, y, -1), Quaternion.identity);

                    playerMap[new Vector2Int(x, y)].GetComponent<MeshRenderer>().material = redMaterial;
                }

                else if (avB > 200 && !playerMap.ContainsKey(new Vector2Int(x, y)))
                {
                    playerMap[new Vector2Int(x, y)] = Instantiate(player, new Vector3(x, y, -1), Quaternion.identity);

                    playerMap[new Vector2Int(x, y)].GetComponent<MeshRenderer>().material = blueMaterial;
                }
            }
        }
    }


    void Start()
    {
        playerMap = new Dictionary<Vector2Int, GameObject>();

        CreateTextureIfNeeded();

        //CheckTiles();
    }

    void Update()
    {



  





        CreateTextureIfNeeded();

        var window = uwcTexture.window;
        if (window == null || window.width == 0) return;

        // GetPixels() can be run in another thread
        if (window.GetPixels(colors, x, y, w, h)) {
            texture.SetPixels32(colors);
            texture.Apply();
        }


        CheckTiles();
    }
}

