using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class OBSSourceScript : MonoBehaviour
{
    [SerializeField]
    private uWindowCapture.UwcWindowTexture uwcTexture;

    [SerializeField]
    private GameObject canvas;

    private int pitchLeft = 154;
    private int pitchTop = 53;
    private int pitchWidth = 780;
    private int pitchHeight = 450;


    private int tileSize = 30;

    private Vector2 res = new Vector2(1920, 1080);






    public RawImage pitchImage;
    public RawImage blueTeamExtras;
    public RawImage blueTeamExtras2;
    public RawImage blueTeamExtras3;
    public RawImage blueTeamExtras4;
    public RawImage blueTeamExtras5;
    public RawImage blueTeamExtras6;
    public RawImage redTeamExtras;
    public RawImage redTeamExtras2;
    public RawImage redTeamExtras3;
    public RawImage redTeamExtras4;
    public RawImage redTeamExtras5;
    public RawImage redTeamExtras6;
    public RawImage weather;
    public RawImage redTeamScore;
    public RawImage blueTeamScore;
    public RawImage redTeamReserves;
    public RawImage redTeamOuts;
    public RawImage blueTeamReserves;
    public RawImage blueTeamOuts;
    public RawImage redTeamBlockDice;
    public RawImage blueTeamBlockDice;

    public RawImage redTeamPlayerStats;
    public RawImage redTeamPlayerCard;
    public RawImage redTeamPlayerType;

    public RawImage redTeamPlayerAllSkills;

    public RawImage blueTeamPlayerStats;
    public RawImage blueTeamPlayerCard;
    public RawImage blueTeamPlayerType;

    public RawImage blueTeamPlayerAllSkills;

    public RawImage blueTurn;
    public RawImage redTurn;
    public RawImage half;

    public RawImage blueTeamPlayersBox;
    public RawImage redTeamPlayersBox;

    public RawImage blueTeamPlayerName;
    public RawImage redTeamPlayerName;

    public RawImage blueTeamPlayerBackground;
    public RawImage redTeamPlayerBackground;

    public RawImage diceLog;




    private Vector2 windowSize = new Vector2(1920, 1080);

    private float verticalBorderWidth = 100;

    private Texture2D pitchTexture;
    private Texture2D blueTeamExtrasTexture;
    private Texture2D blueTeamExtras2Texture;
    private Texture2D blueTeamExtras3Texture;
    private Texture2D blueTeamExtras4Texture;
    private Texture2D blueTeamExtras5Texture;
    private Texture2D blueTeamExtras6Texture;
    private Texture2D redTeamExtrasTexture;
    private Texture2D redTeamExtras2Texture;
    private Texture2D redTeamExtras3Texture;
    private Texture2D redTeamExtras4Texture;
    private Texture2D redTeamExtras5Texture;
    private Texture2D redTeamExtras6Texture;
    private Texture2D weatherTexture;
    private Texture2D redTeamScoreTexture;
    private Texture2D blueTeamScoreTexture;
    private Texture2D redTeamReservesTexture;
    private Texture2D redTeamOutsTexture;
    private Texture2D blueTeamReservesTexture;
    private Texture2D blueTeamOutsTexture;
    private Texture2D redTeamBlockDiceTexture;
    private Texture2D blueTeamBlockDiceTexture;

    private Texture2D redTeamPlayerStatsTexture;
    private Texture2D redTeamPlayerCardTexture;
    private Texture2D redTeamPlayerTypeTexture;

    private Texture2D redTeamPlayerAllSkillsTexture;

    private Texture2D blueTeamPlayerStatsTexture;
    private Texture2D blueTeamPlayerCardTexture;
    private Texture2D blueTeamPlayerTypeTexture;

    private Texture2D blueTeamPlayerAllSkillsTexture;


    private Texture2D blueTurnTexture;
    private Texture2D redTurnTexture;
    private Texture2D halfTexture;

    private Texture2D blueTeamPlayersBoxTexture;
    private Texture2D redTeamPlayersBoxTexture;

    private Texture2D blueTeamPlayerNameTexture;
    private Texture2D redTeamPlayerNameTexture;

    private Texture2D diceLogTexture;

    [SerializeField]
    private RawImage searchingBackground;

    [SerializeField]
    private Text searchingText;

    private string[] searchingStrings = { "Searching for FUMBBL window", "Searching for FUMBBL window.", "Searching for FUMBBL window..", "Searching for FUMBBL window..." };

    private int currentSearchingTextIndex = 0;

    private int searchingStringTime = 20;

    private int searchingStringTimer = 0;

    [SerializeField]
    private Text turnTimer;


    float scalingFactor = 1.0f;



    bool inducementsTopDown = true;

    void SetPitchPixels()
    {


        Color32[] pitchPixels = uwcTexture.window.GetPixels((int)(pitchLeft * scalingFactor), (int)(pitchTop * scalingFactor), (int)(pitchWidth * scalingFactor), (int)(pitchHeight * scalingFactor));

        //Color32[] pitchPixels = uwcTexture.window.GetPixels(0, 0, (int)(pitchWidth * scalingFactor), (int)(pitchHeight * scalingFactor));


        pitchTexture.SetPixels32(pitchPixels);

        pitchTexture.Apply();
    }

    void SetBlueTeamExtrasPixels()
    {
        //Blue team

        Color32[] blueTeamExtrasPixels = uwcTexture.window.GetPixels(uwcTexture.window.rawWidth - 56, uwcTexture.window.rawHeight - 49, 42, 42);

        blueTeamExtrasTexture.SetPixels32(blueTeamExtrasPixels);

        blueTeamExtrasTexture.Apply();


        Color32[] blueTeamExtras2Pixels = uwcTexture.window.GetPixels(uwcTexture.window.rawWidth - 104, uwcTexture.window.rawHeight - 49, 42, 42);

        blueTeamExtras2Texture.SetPixels32(blueTeamExtras2Pixels);

        blueTeamExtras2Texture.Apply();


        Color32[] blueTeamExtras3Pixels = uwcTexture.window.GetPixels(uwcTexture.window.rawWidth - 152, uwcTexture.window.rawHeight - 49, 42, 42);

        blueTeamExtras3Texture.SetPixels32(blueTeamExtras3Pixels);

        blueTeamExtras3Texture.Apply();

        Color32[] blueTeamExtras4Pixels = uwcTexture.window.GetPixels(uwcTexture.window.rawWidth - 56, uwcTexture.window.rawHeight - 92, 42, 42);

        blueTeamExtras4Texture.SetPixels32(blueTeamExtras4Pixels);

        blueTeamExtras4Texture.Apply();


        Color32[] blueTeamExtras5Pixels = uwcTexture.window.GetPixels(uwcTexture.window.rawWidth - 104, uwcTexture.window.rawHeight - 92, 42, 42);

        blueTeamExtras5Texture.SetPixels32(blueTeamExtras5Pixels);

        blueTeamExtras5Texture.Apply();


        Color32[] blueTeamExtras6Pixels = uwcTexture.window.GetPixels(uwcTexture.window.rawWidth - 152, uwcTexture.window.rawHeight - 92, 42, 42);

        blueTeamExtras6Texture.SetPixels32(blueTeamExtras6Pixels);

        blueTeamExtras6Texture.Apply();
    }

    void SetRedTeamExtrasPixels()
    {
        ////Red team

        Color32[] redTeamExtrasPixels = uwcTexture.window.GetPixels(15, uwcTexture.window.rawHeight - 49, 42, 42);

        redTeamExtrasTexture.SetPixels32(redTeamExtrasPixels);

        redTeamExtrasTexture.Apply();


        Color32[] redTeamExtras2Pixels = uwcTexture.window.GetPixels(63, uwcTexture.window.rawHeight - 49, 42, 42);

        redTeamExtras2Texture.SetPixels32(redTeamExtras2Pixels);

        redTeamExtras2Texture.Apply();



        Color32[] redTeamExtras3Pixels = uwcTexture.window.GetPixels(111, uwcTexture.window.rawHeight - 49, 42, 42);

        redTeamExtras3Texture.SetPixels32(redTeamExtras3Pixels);

        redTeamExtras3Texture.Apply();



        Color32[] redTeamExtras4Pixels = uwcTexture.window.GetPixels(15, uwcTexture.window.rawHeight - 92, 42, 42);

        redTeamExtras4Texture.SetPixels32(redTeamExtras4Pixels);

        redTeamExtras4Texture.Apply();


        Color32[] redTeamExtras5Pixels = uwcTexture.window.GetPixels(63, uwcTexture.window.rawHeight - 92, 42, 42);

        redTeamExtras5Texture.SetPixels32(redTeamExtras5Pixels);

        redTeamExtras5Texture.Apply();



        Color32[] redTeamExtras6Pixels = uwcTexture.window.GetPixels(111, uwcTexture.window.rawHeight - 92, 42, 42);

        redTeamExtras6Texture.SetPixels32(redTeamExtras6Pixels);

        redTeamExtras6Texture.Apply();

    }

    void SetWeatherPixels()
    {
        Color32[] weatherPixels = uwcTexture.window.GetPixels(835, 505, 100, 30);

        weatherTexture.SetPixels32(weatherPixels);

        weatherTexture.Apply();
    }

    void SetScorePixels()
    {
        Color32[] redScorePixels = uwcTexture.window.GetPixels(480, 505, 40, 30);

        redTeamScoreTexture.SetPixels32(redScorePixels);

        redTeamScoreTexture.Apply();

        Color32[] blueScorePixels = uwcTexture.window.GetPixels(565, 505, 40, 30);

        blueTeamScoreTexture.SetPixels32(blueScorePixels);

        blueTeamScoreTexture.Apply();
    }

    void SetReservesandOutsPixels()
    {
        Color32[] redTeamReservesPixels = uwcTexture.window.GetPixels(9, 482, 72, 22);

        redTeamReservesTexture.SetPixels32(redTeamReservesPixels);

        redTeamReservesTexture.Apply();

        Color32[] redTeamOutsPixels = uwcTexture.window.GetPixels(81, 482, 72, 22);

        redTeamOutsTexture.SetPixels32(redTeamOutsPixels);

        redTeamOutsTexture.Apply();

        Color32[] blueTeamReservesPixels = uwcTexture.window.GetPixels(1008, 482, 72, 22);

        blueTeamReservesTexture.SetPixels32(blueTeamReservesPixels);

        blueTeamReservesTexture.Apply();

        Color32[] blueTeamOutsPixels = uwcTexture.window.GetPixels(936, 482, 72, 22);

        blueTeamOutsTexture.SetPixels32(blueTeamOutsPixels);

        blueTeamOutsTexture.Apply();
    }


    void SetBlockDice()
    {
        Color32[] blueTeamBlockDicePixels = uwcTexture.window.GetPixels(936, 542, 140, 35);

        if (blueTeamBlockDicePixels[0][0] == 51 && blueTeamBlockDicePixels[0][0] == 51 && blueTeamBlockDicePixels[0][0] == 51)
        {
            blueTeamBlockDiceTexture.SetPixels32(blueTeamBlockDicePixels);

            blueTeamBlockDiceTexture.Apply();
        }

        Color32[] redTeamBlockDicePixels = uwcTexture.window.GetPixels(10, 542, 140, 35);

        if (redTeamBlockDicePixels[0][0] == 51 && redTeamBlockDicePixels[0][0] == 51 && redTeamBlockDicePixels[0][0] == 51)
        {
            redTeamBlockDiceTexture.SetPixels32(redTeamBlockDicePixels);

            redTeamBlockDiceTexture.Apply();
        }
    }

    void SetRedTeamPlayerBox()
    {
        bool showBox = false;

        Color32 redOutCheckPixel = uwcTexture.window.GetPixel(91, 492);

        if (redOutCheckPixel[0] == 132 && redOutCheckPixel[1] == 132 && redOutCheckPixel[2] == 132)
        {
            showBox = true;
        }

        Color32 redReserveCheckPixel = uwcTexture.window.GetPixel(19, 492);

        if (redReserveCheckPixel[0] == 132 && redReserveCheckPixel[1] == 132 && redReserveCheckPixel[2] == 132)
        {
            showBox = true;
        }

        if (showBox)
        {
            redTeamPlayersBox.enabled = true;

            Color32[] redTeamPlayersBoxPixels = uwcTexture.window.GetPixels(8, 53, 145, 430);

            redTeamPlayersBoxTexture.SetPixels32(redTeamPlayersBoxPixels);

            redTeamPlayersBoxTexture.Apply();
        }

        else
        {
            redTeamPlayersBox.enabled = false;
        }
    }

    void SetBlueTeamPlayerBox()
    {
        bool showBox = false;

        Color32 blueOutCheckPixel = uwcTexture.window.GetPixel(946, 492);

        if (blueOutCheckPixel[0] == 132 && blueOutCheckPixel[1] == 132 && blueOutCheckPixel[2] == 132)
        {
            showBox = true;
        }

        Color32 blueReserveCheckPixel = uwcTexture.window.GetPixel(1018, 492);

        if (blueReserveCheckPixel[0] == 132 && blueReserveCheckPixel[1] == 132 && blueReserveCheckPixel[2] == 132)
        {
            showBox = true;
        }

        if (showBox)
        {
            blueTeamPlayersBox.enabled = true;

            Color32[] blueTeamPlayersBoxPixels = uwcTexture.window.GetPixels(935, 53, 145, 430);

            blueTeamPlayersBoxTexture.SetPixels32(blueTeamPlayersBoxPixels);

            blueTeamPlayersBoxTexture.Apply();
        }

        else
        {
            blueTeamPlayersBox.enabled = false;
        }
    }

    void SetBlueTeamPlayerCard()
    {
        //Check for coloured player card pixel - if red, set background to red, if blue, set background to blue, else, disable background
        //Same for redplayer

        bool redCard = false;

        bool blueCard = false;

        Color32 blueTeamPlayerCardCheck = uwcTexture.window.GetPixel(951, 84);

        if (blueTeamPlayerCardCheck.r < 40 && blueTeamPlayerCardCheck.b > 150)
            blueCard = true;


        if (blueTeamPlayerCardCheck.r > 150 && blueTeamPlayerCardCheck.b < 40)
            redCard = true;

        Color32 backgroundColor;

        if (blueCard)
            backgroundColor = new Color32(30, 0, 203, 255);

        else if (redCard)
            backgroundColor = new Color32(203, 0, 30, 255);

        else
            backgroundColor = new Color32(0, 0, 0, 0);

        blueTeamPlayerBackground.color = backgroundColor;


        //Check to see if the outs or reserves box is selected

        Color32 blueOutCheckPixel = uwcTexture.window.GetPixel(946, 492);

        if (blueOutCheckPixel[0] == 132 && blueOutCheckPixel[1] == 132 && blueOutCheckPixel[2] == 132)
        {
            blueTeamPlayerStats.enabled = false;

            blueTeamPlayerCard.enabled = false;

            blueTeamPlayerType.enabled = false;

            blueTeamPlayerAllSkills.enabled = false;

            blueTeamPlayerBackground.enabled = false;

            blueTeamPlayerName.enabled = false;

            return;
        }

        Color32 blueReserveCheckPixel = uwcTexture.window.GetPixel(1018, 492);

        if (blueReserveCheckPixel[0] == 132 && blueReserveCheckPixel[1] == 132 && blueReserveCheckPixel[2] == 132)
        {
            blueTeamPlayerStats.enabled = false;

            blueTeamPlayerCard.enabled = false;

            blueTeamPlayerType.enabled = false;

            blueTeamPlayerAllSkills.enabled = false;

            blueTeamPlayerBackground.enabled = false;

            blueTeamPlayerName.enabled = false;

            return;
        }

        blueTeamPlayerStats.enabled = true;

        blueTeamPlayerCard.enabled = true;

        blueTeamPlayerType.enabled = true;

        blueTeamPlayerAllSkills.enabled = true;

        blueTeamPlayerBackground.enabled = true;

        blueTeamPlayerName.enabled = true;

        //Name
        Color32[] blueTeamPlayerNamePixels = uwcTexture.window.GetPixels(938, 71, 140, 12);

        for (int i = 0; i < blueTeamPlayerNamePixels.Length; i++)
        {
            if (blueTeamPlayerNamePixels[i][0] == 255 && blueTeamPlayerNamePixels[i][1] == 255 && blueTeamPlayerNamePixels[i][2] == 255)
            {
                blueTeamPlayerNamePixels[i][0] = 253;
                blueTeamPlayerNamePixels[i][1] = 253;
                blueTeamPlayerNamePixels[i][2] = 150;
                blueTeamPlayerNamePixels[i][3] = 255;
            }

            else if (blueTeamPlayerNamePixels[i][0] == 0 && blueTeamPlayerNamePixels[i][1] == 0 && blueTeamPlayerNamePixels[i][2] == 0)
            {
            }

            else
            {
                blueTeamPlayerNamePixels[i] = backgroundColor;
            }
        }

        blueTeamPlayerNameTexture.SetPixels32(blueTeamPlayerNamePixels);

        blueTeamPlayerNameTexture.Apply();


        //Stats

        Color32[] blueTeamPlayerStatsPixels = uwcTexture.window.GetPixels(939, 232, 139, 29);

        for (int i = 0; i < blueTeamPlayerStatsPixels.Length; i++)
        {
            if (blueTeamPlayerStatsPixels[i][0] == blueTeamPlayerStatsPixels[i][1] && blueTeamPlayerStatsPixels[i][1] == blueTeamPlayerStatsPixels[i][2])
            {
            }

            else if (blueTeamPlayerStatsPixels[i][0] == 255 && blueTeamPlayerStatsPixels[i][1] == 0 && blueTeamPlayerStatsPixels[i][2] == 0)
            {
            }

            else if (blueTeamPlayerStatsPixels[i][0] == 0 && blueTeamPlayerStatsPixels[i][1] == 255 && blueTeamPlayerStatsPixels[i][2] == 0)
            {
            }

            else
            {
                blueTeamPlayerStatsPixels[i] = backgroundColor;
            }
        }

        blueTeamPlayerStatsTexture.SetPixels32(blueTeamPlayerStatsPixels);

        blueTeamPlayerStatsTexture.Apply();


        //Player card

        Color32[] blueTeamPlayerCardPixels = uwcTexture.window.GetPixels(951, 84, 100, 146);

        blueTeamPlayerCardTexture.SetPixels32(blueTeamPlayerCardPixels);

        blueTeamPlayerCardTexture.Apply();


        //Player type

        Color32[] blueTeamPlayerTypePixels = uwcTexture.window.GetPixels(1062, 54, 15, 174);

        for (int i = 0; i < blueTeamPlayerTypePixels.Length; i++)
        {
            if (blueTeamPlayerTypePixels[i][0] == 255 && blueTeamPlayerTypePixels[i][1] == 255 && blueTeamPlayerTypePixels[i][2] == 255)
            {
            }

            else if (blueTeamPlayerTypePixels[i][0] == 0 && blueTeamPlayerTypePixels[i][1] == 0 && blueTeamPlayerTypePixels[i][2] == 0)
            {
            }

            else
            {
                blueTeamPlayerTypePixels[i] = backgroundColor;
            }
        }

        blueTeamPlayerTypeTexture.SetPixels32(blueTeamPlayerTypePixels);

        blueTeamPlayerTypeTexture.Apply();


        //Skills

        Color32[] blueTeamPlayerSkillsPixels = uwcTexture.window.GetPixels(939, 278, 130, 180);

        for (int i = 0; i < blueTeamPlayerSkillsPixels.Length; i++)
        {
            if (blueTeamPlayerSkillsPixels[i][0] == 0 && blueTeamPlayerSkillsPixels[i][1] == 0 && blueTeamPlayerSkillsPixels[i][2] == 0)
            {
                blueTeamPlayerSkillsPixels[i][0] = 255;
                blueTeamPlayerSkillsPixels[i][1] = 255;
                blueTeamPlayerSkillsPixels[i][2] = 255;
                blueTeamPlayerSkillsPixels[i][3] = 255;
            }

            else if (blueTeamPlayerSkillsPixels[i][0] == 0 && blueTeamPlayerSkillsPixels[i][1] == 96 && blueTeamPlayerSkillsPixels[i][2] == 0)
            {
                blueTeamPlayerSkillsPixels[i][0] = 0;
                blueTeamPlayerSkillsPixels[i][1] = 150;
                blueTeamPlayerSkillsPixels[i][2] = 0;
                blueTeamPlayerSkillsPixels[i][3] = 255;
            }

            else if (blueTeamPlayerSkillsPixels[i][0] == 220 && blueTeamPlayerSkillsPixels[i][1] == 0 && blueTeamPlayerSkillsPixels[i][2] == 0)
            {
                blueTeamPlayerSkillsPixels[i][0] = 150;
                blueTeamPlayerSkillsPixels[i][1] = 0;
                blueTeamPlayerSkillsPixels[i][2] = 0;
                blueTeamPlayerSkillsPixels[i][3] = 255;
            }

            else
            {
                blueTeamPlayerSkillsPixels[i][0] = 0;
                blueTeamPlayerSkillsPixels[i][1] = 0;
                blueTeamPlayerSkillsPixels[i][2] = 0;
                blueTeamPlayerSkillsPixels[i][3] = 0;
            }
        }

        blueTeamPlayerAllSkillsTexture.SetPixels32(blueTeamPlayerSkillsPixels);

        blueTeamPlayerAllSkillsTexture.Apply();
    }

    void SetRedTeamPlayerCard()
    {
        //Check for coloured player card pixel - if red, set background to red, if blue, set background to blue, else, disable background
        //Same for redplayer

        bool redCard = false;

        bool blueCard = false;

        Color32 redTeamPlayerCardCheck = uwcTexture.window.GetPixel(22, 84);

        if (redTeamPlayerCardCheck.r < 40 && redTeamPlayerCardCheck.b > 150)
            blueCard = true;

        if (redTeamPlayerCardCheck.r > 150 && redTeamPlayerCardCheck.b < 40)
            redCard = true;

        Color32 backgroundColor;

        if (blueCard)
            backgroundColor = new Color32(30, 0, 203, 255);

        else if (redCard)
            backgroundColor = new Color32(203, 0, 30, 255);

        else
            backgroundColor = new Color32(0, 0, 0, 0);

        redTeamPlayerBackground.color = backgroundColor;

        Color32 redOutCheckPixel = uwcTexture.window.GetPixel(91, 492);

        if (redOutCheckPixel[0] == 132 && redOutCheckPixel[1] == 132 && redOutCheckPixel[2] == 132)
        {
            redTeamPlayerStats.enabled = false;

            redTeamPlayerCard.enabled = false;

            redTeamPlayerType.enabled = false;

            redTeamPlayerAllSkills.enabled = false;

            redTeamPlayerName.enabled = false;

            redTeamPlayerBackground.enabled = false;

            return;
        }

        Color32 redReserveCheckPixel = uwcTexture.window.GetPixel(19, 492);

        if (redReserveCheckPixel[0] == 132 && redReserveCheckPixel[1] == 132 && redReserveCheckPixel[2] == 132)
        {
            redTeamPlayerStats.enabled = false;

            redTeamPlayerCard.enabled = false;

            redTeamPlayerType.enabled = false;

            redTeamPlayerAllSkills.enabled = false;

            redTeamPlayerName.enabled = false;

            redTeamPlayerBackground.enabled = false;

            return;
        }

        redTeamPlayerStats.enabled = true;

        redTeamPlayerCard.enabled = true;

        redTeamPlayerType.enabled = true;

        redTeamPlayerAllSkills.enabled = true;

        redTeamPlayerName.enabled = true;

        redTeamPlayerBackground.enabled = true;


        //Name

        Color32[] redTeamPlayerNamePixels = uwcTexture.window.GetPixels(10, 71, 140, 12);

        for (int i = 0; i < redTeamPlayerNamePixels.Length; i++)
        {
            if (redTeamPlayerNamePixels[i][0] == 255 && redTeamPlayerNamePixels[i][1] == 255 && redTeamPlayerNamePixels[i][2] == 255)
            {
                redTeamPlayerNamePixels[i][0] = 253;
                redTeamPlayerNamePixels[i][1] = 253;
                redTeamPlayerNamePixels[i][2] = 150;
                redTeamPlayerNamePixels[i][3] = 255;
            }

            else if (redTeamPlayerNamePixels[i][0] == 0 && redTeamPlayerNamePixels[i][1] == 0 && redTeamPlayerNamePixels[i][2] == 0)
            {
            }

            else
                redTeamPlayerNamePixels[i] = backgroundColor;
        }

        redTeamPlayerNameTexture.SetPixels32(redTeamPlayerNamePixels);

        redTeamPlayerNameTexture.Apply();


        //Stats

        Color32[] redTeamPlayerStatsPixels = uwcTexture.window.GetPixels(11, 232, 139, 29);

        for (int i = 0; i < redTeamPlayerStatsPixels.Length; i++)
        {
            if (redTeamPlayerStatsPixels[i][0] == redTeamPlayerStatsPixels[i][1] && redTeamPlayerStatsPixels[i][1] == redTeamPlayerStatsPixels[i][2])
            {
            }

            else if (redTeamPlayerStatsPixels[i][0] == 255 && redTeamPlayerStatsPixels[i][1] == 0 && redTeamPlayerStatsPixels[i][2] == 0)
            {
            }

            else if (redTeamPlayerStatsPixels[i][0] == 0 && redTeamPlayerStatsPixels[i][1] == 255 && redTeamPlayerStatsPixels[i][2] == 0)
            {
            }

            else
                redTeamPlayerStatsPixels[i] = backgroundColor;
        }

        redTeamPlayerStatsTexture.SetPixels32(redTeamPlayerStatsPixels);

        redTeamPlayerStatsTexture.Apply();


        //Player card

        Color32[] redTeamPlayerCardPixels = uwcTexture.window.GetPixels(22, 84, 100, 146);

        redTeamPlayerCardTexture.SetPixels32(redTeamPlayerCardPixels);

        redTeamPlayerCardTexture.Apply();


        //Player type

        Color32[] redTeamPlayerTypePixels = uwcTexture.window.GetPixels(133, 54, 15, 174);

        for (int i = 0; i < redTeamPlayerTypePixels.Length; i++)
        {
            if (redTeamPlayerTypePixels[i][0] == 255 && redTeamPlayerTypePixels[i][1] == 255 && redTeamPlayerTypePixels[i][2] == 255)
            {
            }

            else if (redTeamPlayerTypePixels[i][0] == 0 && redTeamPlayerTypePixels[i][1] == 0 && redTeamPlayerTypePixels[i][2] == 0)
            {
            }

            else
                redTeamPlayerTypePixels[i] = backgroundColor;
        }

        redTeamPlayerTypeTexture.SetPixels32(redTeamPlayerTypePixels);

        redTeamPlayerTypeTexture.Apply();


        //Skills

        Color32[] redTeamPlayerSkillsPixels = uwcTexture.window.GetPixels(11, 278, 130, 180);

        for (int i = 0; i < redTeamPlayerSkillsPixels.Length; i++)
        {
            if (redTeamPlayerSkillsPixels[i][0] == 0 && redTeamPlayerSkillsPixels[i][1] == 0 && redTeamPlayerSkillsPixels[i][2] == 0)
            {
                redTeamPlayerSkillsPixels[i][0] = 255;
                redTeamPlayerSkillsPixels[i][1] = 255;
                redTeamPlayerSkillsPixels[i][2] = 255;
                redTeamPlayerSkillsPixels[i][3] = 255;
            }

            else if (redTeamPlayerSkillsPixels[i][0] == 0 && redTeamPlayerSkillsPixels[i][1] == 96 && redTeamPlayerSkillsPixels[i][2] == 0)
            {
                redTeamPlayerSkillsPixels[i][0] = 0;
                redTeamPlayerSkillsPixels[i][1] = 150;
                redTeamPlayerSkillsPixels[i][2] = 0;
                redTeamPlayerSkillsPixels[i][3] = 255;
            }

            else if (redTeamPlayerSkillsPixels[i][0] == 220 && redTeamPlayerSkillsPixels[i][1] == 0 && redTeamPlayerSkillsPixels[i][2] == 0)
            {
                redTeamPlayerSkillsPixels[i][0] = 150;
                redTeamPlayerSkillsPixels[i][1] = 0;
                redTeamPlayerSkillsPixels[i][2] = 0;
                redTeamPlayerSkillsPixels[i][3] = 255;
            }

            else
            {
                redTeamPlayerSkillsPixels[i][0] = 0;
                redTeamPlayerSkillsPixels[i][1] = 0;
                redTeamPlayerSkillsPixels[i][2] = 0;
                redTeamPlayerSkillsPixels[i][3] = 0;
            }
        }

        redTeamPlayerAllSkillsTexture.SetPixels32(redTeamPlayerSkillsPixels);

        redTeamPlayerAllSkillsTexture.Apply();
    }

    void SetTurn()
    {
        Color32[] halfPixels = uwcTexture.window.GetPixels(267, 506, 28, 22);

        for (int i = 0; i < halfPixels.Length; i++)
        {
            if (halfPixels[i][0] == 255 && halfPixels[i][1] == 255 && halfPixels[i][2] == 255)
            {
                halfPixels[i][0] = 253;
                halfPixels[i][1] = 253;
                halfPixels[i][2] = 150;
                halfPixels[i][3] = 255;
            }
        }

        halfTexture.SetPixels32(halfPixels);

        halfTexture.Apply();

        Color32[] redTurnPixels = uwcTexture.window.GetPixels(191, 511, 22, 22);

        for (int i = 0; i < redTurnPixels.Length; i++)
        {
            if (redTurnPixels[i][0] == 255 && redTurnPixels[i][1] == 255 && redTurnPixels[i][2] == 255)
            {
                redTurnPixels[i][0] = 253;
                redTurnPixels[i][1] = 253;
                redTurnPixels[i][2] = 150;
                redTurnPixels[i][3] = 255;
            }
        }

        redTurnTexture.SetPixels32(redTurnPixels);

        redTurnTexture.Apply();

        Color32[] blueTurnPixels = uwcTexture.window.GetPixels(226, 511, 22, 22);

        for (int i = 0; i < blueTurnPixels.Length; i++)
        {
            if (blueTurnPixels[i][0] == 255 && blueTurnPixels[i][1] == 255 && blueTurnPixels[i][2] == 255)
            {
                blueTurnPixels[i][0] = 253;
                blueTurnPixels[i][1] = 253;
                blueTurnPixels[i][2] = 150;
                blueTurnPixels[i][3] = 255;
            }
        }

        blueTurnTexture.SetPixels32(blueTurnPixels);

        blueTurnTexture.Apply();
    }

    void SetDiceLog()
    {
        Color32[] diceLogPixels = uwcTexture.window.GetPixels(155, 655, 370, 90);

        diceLogTexture.SetPixels32(diceLogPixels);

        diceLogTexture.Apply();
    }



    void Start()
    {
        SetInducementPositions();

        Application.runInBackground = true;

        //Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);


        //pitchElement = new UIElement((int)(pitchWidth * scalingFactor), (int)(pitchHeight * scalingFactor), canvas);


        //TEXTURES

        //pitchElement.Texture = new Texture2D((int)(pitchWidth * scalingFactor), (int)(pitchHeight * scalingFactor));

        pitchTexture = new Texture2D((int)(pitchWidth * scalingFactor), (int)(pitchHeight * scalingFactor));

        blueTeamExtrasTexture = new Texture2D(42, 42);

        blueTeamExtras2Texture = new Texture2D(42, 42);

        blueTeamExtras3Texture = new Texture2D(42, 42);

        blueTeamExtras4Texture = new Texture2D(42, 42);

        blueTeamExtras5Texture = new Texture2D(42, 42);

        blueTeamExtras6Texture = new Texture2D(42, 42);

        redTeamExtrasTexture = new Texture2D(42, 42);

        redTeamExtras2Texture = new Texture2D(42, 42);

        redTeamExtras3Texture = new Texture2D(42, 42);

        redTeamExtras4Texture = new Texture2D(42, 42);

        redTeamExtras5Texture = new Texture2D(42, 42);

        redTeamExtras6Texture = new Texture2D(42, 42);

        weatherTexture = new Texture2D(100, 30);

        redTeamScoreTexture = new Texture2D(40, 30);

        blueTeamScoreTexture = new Texture2D(40, 30);

        redTeamReservesTexture = new Texture2D(72, 22);

        redTeamOutsTexture = new Texture2D(72, 22);

        blueTeamReservesTexture = new Texture2D(72, 22);

        blueTeamOutsTexture = new Texture2D(72, 22);

        redTeamBlockDiceTexture = new Texture2D(140, 35);

        blueTeamBlockDiceTexture = new Texture2D(140, 35);

        redTeamPlayerStatsTexture = new Texture2D(139, 29);

        redTeamPlayerCardTexture = new Texture2D(100, 146);

        redTeamPlayerTypeTexture = new Texture2D(15, 174);

        redTeamPlayerAllSkillsTexture = new Texture2D(130, 180);

        blueTeamPlayerAllSkillsTexture = new Texture2D(130, 180);

        blueTurnTexture = new Texture2D(22, 22);

        redTurnTexture = new Texture2D(22, 22);

        halfTexture = new Texture2D(28, 22);

        blueTeamPlayerNameTexture = new Texture2D(140, 12);
        redTeamPlayerNameTexture = new Texture2D(140, 12);

        blueTeamPlayerStatsTexture = new Texture2D(139, 29);

        blueTeamPlayerCardTexture = new Texture2D(100, 146);

        blueTeamPlayerTypeTexture = new Texture2D(15, 174);

        blueTeamPlayersBoxTexture = new Texture2D(145, 430);

        redTeamPlayersBoxTexture = new Texture2D(145, 430);

        diceLogTexture = new Texture2D(370, 90);


        //IMAGES

        blueTeamExtras.rectTransform.sizeDelta = new Vector2(84, 84);
        blueTeamExtras.texture = blueTeamExtrasTexture;


        blueTeamExtras2.rectTransform.sizeDelta = new Vector2(84, 84);
        blueTeamExtras2.texture = blueTeamExtras2Texture;


        blueTeamExtras3.rectTransform.sizeDelta = new Vector2(84, 84);
        blueTeamExtras3.texture = blueTeamExtras3Texture;

        blueTeamExtras4.rectTransform.sizeDelta = new Vector2(84, 84);
        blueTeamExtras4.texture = blueTeamExtras4Texture;


        blueTeamExtras5.rectTransform.sizeDelta = new Vector2(84, 84);
        blueTeamExtras5.texture = blueTeamExtras5Texture;


        blueTeamExtras6.rectTransform.sizeDelta = new Vector2(84, 84);
        blueTeamExtras6.texture = blueTeamExtras6Texture;


        redTeamExtras.rectTransform.sizeDelta = new Vector2(84, 84);
        redTeamExtras.texture = redTeamExtrasTexture;


        redTeamExtras2.rectTransform.sizeDelta = new Vector2(84, 84);
        redTeamExtras2.texture = redTeamExtras2Texture;


        redTeamExtras3.rectTransform.sizeDelta = new Vector2(84, 84);
        redTeamExtras3.texture = redTeamExtras3Texture;


        redTeamExtras4.rectTransform.sizeDelta = new Vector2(84, 84);
        redTeamExtras4.texture = redTeamExtras4Texture;


        redTeamExtras5.rectTransform.sizeDelta = new Vector2(84, 84);
        redTeamExtras5.texture = redTeamExtras5Texture;


        redTeamExtras6.rectTransform.sizeDelta = new Vector2(84, 84);
        redTeamExtras6.texture = redTeamExtras6Texture;


        weather.rectTransform.sizeDelta = new Vector2(200, 60);

        weather.texture = weatherTexture;

        redTeamScore.rectTransform.sizeDelta = new Vector2(80, 60);

        redTeamScore.texture = redTeamScoreTexture;

        blueTeamScore.rectTransform.sizeDelta = new Vector2(80, 60);

        blueTeamScore.texture = blueTeamScoreTexture;

        redTeamReserves.rectTransform.sizeDelta = new Vector2(144, 44);

        redTeamReserves.texture = redTeamReservesTexture;

        redTeamOuts.rectTransform.sizeDelta = new Vector2(144, 44);

        redTeamOuts.texture = redTeamOutsTexture;

        blueTeamReserves.rectTransform.sizeDelta = new Vector2(144, 44);

        blueTeamReserves.texture = blueTeamReservesTexture;

        blueTeamOuts.rectTransform.sizeDelta = new Vector2(144, 44);

        blueTeamOuts.texture = blueTeamOutsTexture;

        redTeamBlockDice.rectTransform.sizeDelta = new Vector2(280, 70);

        redTeamBlockDice.texture = redTeamBlockDiceTexture;

        blueTeamBlockDice.rectTransform.sizeDelta = new Vector2(280, 70);

        blueTeamBlockDice.texture = blueTeamBlockDiceTexture;

        redTeamPlayerStats.rectTransform.sizeDelta = new Vector2(278, 58);
        redTeamPlayerStats.texture = redTeamPlayerStatsTexture;

        redTeamPlayerCard.rectTransform.sizeDelta = new Vector2(100, 146);
        redTeamPlayerCard.texture = redTeamPlayerCardTexture;

        redTeamPlayerType.rectTransform.sizeDelta = new Vector2(30, 348);
        redTeamPlayerType.texture = redTeamPlayerTypeTexture;

        redTeamPlayerAllSkills.rectTransform.sizeDelta = new Vector2(130, 180);
        redTeamPlayerAllSkills.texture = redTeamPlayerAllSkillsTexture;

        blueTeamPlayerStats.rectTransform.sizeDelta = new Vector2(278, 58);
        blueTeamPlayerStats.texture = blueTeamPlayerStatsTexture;

        blueTeamPlayerCard.rectTransform.sizeDelta = new Vector2(100, 146);
        blueTeamPlayerCard.texture = blueTeamPlayerCardTexture;

        blueTeamPlayerType.rectTransform.sizeDelta = new Vector2(30, 348);
        blueTeamPlayerType.texture = blueTeamPlayerTypeTexture;

        blueTeamPlayerAllSkills.rectTransform.sizeDelta = new Vector2(130, 180);
        blueTeamPlayerAllSkills.texture = blueTeamPlayerAllSkillsTexture;

        blueTurn.rectTransform.sizeDelta = new Vector2(44, 44);
        blueTurn.texture = blueTurnTexture;

        redTurn.rectTransform.sizeDelta = new Vector2(44, 44);
        redTurn.texture = redTurnTexture;

        half.rectTransform.sizeDelta = new Vector2(56, 44);
        half.texture = halfTexture;

        blueTeamPlayersBox.rectTransform.sizeDelta = new Vector2(290, 860);
        blueTeamPlayersBox.texture = blueTeamPlayersBoxTexture;

        redTeamPlayersBox.rectTransform.sizeDelta = new Vector2(290, 860);
        redTeamPlayersBox.texture = redTeamPlayersBoxTexture;

        redTeamPlayerName.rectTransform.sizeDelta = new Vector2(140, 12);
        redTeamPlayerName.texture = redTeamPlayerNameTexture;

        blueTeamPlayerName.rectTransform.sizeDelta = new Vector2(140, 12);
        blueTeamPlayerName.texture = blueTeamPlayerNameTexture;

        diceLog.rectTransform.sizeDelta = new Vector2(370, 90);
        diceLog.texture = diceLogTexture;

        float pitchImageWidth = windowSize.x - verticalBorderWidth * 2;

        float pitchImageHeight = ((float)pitchHeight / (float)pitchWidth) * pitchImageWidth;

        float horizontalBorder = windowSize.y - pitchImageHeight;



        //pitchImage.rectTransform.position = new Vector3(windowSize.x / 2, windowSize.y / 2f - horizontalBorder / 2f, 0);

        //pitchElement.Image.rectTransform.sizeDelta = new Vector2(pitchImageWidth, pitchImageHeight);

        //pitchElement.Image.rectTransform.position = new Vector3(pitchImage.rectTransform.position.x, 0, 0);





        pitchImage.rectTransform.sizeDelta = new Vector2(pitchImageWidth, pitchImageHeight);

        pitchImage.rectTransform.position = new Vector3(pitchImage.rectTransform.position.x, 0, 0);

        pitchImage.texture = pitchTexture;
    }

    private void SetTurnTime()
    {
        string title = uwcTexture.window.title;

        

        for (int i = 0; i < title.Length - 6; i++)
        {
            if (title.Substring(i, 6) == " Turn ")
            {
                int numMinutes, numSeconds;

                if (!int.TryParse(title.Substring(i + 6, 2), out numMinutes))
                    return;


                if (!int.TryParse(title.Substring(i + 9, 2), out numSeconds))
                    return;

                numSeconds += numMinutes * 60;

                int remainingSeconds = (4 * 60 - numSeconds) % (int)60;

                int remainingMinutes = (4 * 60 - numSeconds) / (int)60;

                if (remainingSeconds <= 9)
                    turnTimer.text = remainingMinutes + ":0" + remainingSeconds;

                else
                    turnTimer.text = remainingMinutes + ":" + remainingSeconds;


                return;
            }
        }

        turnTimer.text = "";

    }


    private void SetInducementPositions()
    {
        if (inducementsTopDown)
        {
            redTeamExtras.rectTransform.position = new Vector3(10, 550, 0);
            redTeamExtras2.rectTransform.position = new Vector3(10, 470, 0);
            redTeamExtras3.rectTransform.position = new Vector3(10, 390, 0);
            redTeamExtras4.rectTransform.position = new Vector3(10, 310, 0);
            redTeamExtras5.rectTransform.position = new Vector3(10, 230, 0);
            redTeamExtras6.rectTransform.position = new Vector3(10, 150, 0);

            blueTeamExtras.rectTransform.position = new Vector3(1916, 550, 0);
            blueTeamExtras2.rectTransform.position = new Vector3(1916, 470, 0);
            blueTeamExtras3.rectTransform.position = new Vector3(1916, 390, 0);
            blueTeamExtras4.rectTransform.position = new Vector3(1916, 310, 0);
            blueTeamExtras5.rectTransform.position = new Vector3(1916, 230, 0);
            blueTeamExtras6.rectTransform.position = new Vector3(1916, 150, 0);
        }

        else
        {

            redTeamExtras.rectTransform.position = new Vector3(10, 0, 0);
            redTeamExtras2.rectTransform.position = new Vector3(10, 80, 0);
            redTeamExtras3.rectTransform.position = new Vector3(10, 160, 0);
            redTeamExtras4.rectTransform.position = new Vector3(10, 240, 0);
            redTeamExtras5.rectTransform.position = new Vector3(10, 320, 0);
            redTeamExtras6.rectTransform.position = new Vector3(10, 400, 0);

            blueTeamExtras.rectTransform.position = new Vector3(1916, 0, 0);
            blueTeamExtras2.rectTransform.position = new Vector3(1916, 80, 0);
            blueTeamExtras3.rectTransform.position = new Vector3(1916, 160, 0);
            blueTeamExtras4.rectTransform.position = new Vector3(1916, 240, 0);
            blueTeamExtras5.rectTransform.position = new Vector3(1916, 320, 0);
            blueTeamExtras6.rectTransform.position = new Vector3(1916, 400, 0);
        }
    }

    void Update()
    {
        //Input to quit
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();


        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inducementsTopDown = !inducementsTopDown;

            SetInducementPositions();
        }


        //Input to toggle between fullscren and windowed mode
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.W))
        {
            if (Screen.fullScreenMode == FullScreenMode.Windowed)
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;

            else
                Screen.fullScreenMode = FullScreenMode.Windowed;
        }

        //Check if the FUMBBL window has been grabbed
        if (uwcTexture.window == null)
        {
            uwcTexture.RequestWindowUpdate();
            return;
        }


        else if (uwcTexture.window.width != scalingFactor * 1074 || uwcTexture.window.height != scalingFactor * 765)
        {


            uwcTexture.RequestWindowUpdate();
            return;
        }

        else
        {

            uwcTexture.window.RequestUpdateTitle();
        }

        SetPitchPixels();

        SetBlueTeamExtrasPixels();

        SetRedTeamExtrasPixels();

        SetWeatherPixels();

        SetScorePixels();

        SetReservesandOutsPixels();

        SetTurn();

        SetBlockDice();

        SetRedTeamPlayerCard();

        SetBlueTeamPlayerCard();

        SetRedTeamPlayerBox();

        SetBlueTeamPlayerBox();

        SetTurnTime();

        SetDiceLog();
    }

    private void FixedUpdate()
    {
        if (uwcTexture.window == null || uwcTexture.window.width != 1074 || uwcTexture.window.height != 765)
        {
            searchingText.enabled = true;
            searchingBackground.enabled = true;

            UpdateSearchingString();
        }

        else
        {
            searchingText.enabled = false;
            searchingBackground.enabled = false;
        }
    }

    private void UpdateSearchingString()
    {
        searchingStringTimer++;

        if (searchingStringTimer >= searchingStringTime)
        {
            searchingStringTimer = 0;

            currentSearchingTextIndex++;

            if (currentSearchingTextIndex > 3)
                currentSearchingTextIndex = 0;

            searchingText.text = searchingStrings[currentSearchingTextIndex];
        }
    }
}