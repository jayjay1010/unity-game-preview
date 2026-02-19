using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    public static Sprite selectedSprite;  // store selected skin globally
    private int selectedSkin = 0;

    public void NextOption()
    {
        selectedSkin++;
        if (selectedSkin == skins.Count)
            selectedSkin = 0;

        sr.sprite = skins[selectedSkin];
    }

    public void BackOption()
    {
        selectedSkin--;
        if (selectedSkin < 0)
            selectedSkin = skins.Count - 1;

        sr.sprite = skins[selectedSkin];
    }

    public void PlayGame()
    {
        selectedSprite = skins[selectedSkin]; // store selection
        SceneManager.LoadScene("Level 1");   // go to game scene
    }
}

/*public class SkinManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerskin;

    public void NextOption()
    {
        selectedSkin = selectedSkin + 1;
        if (selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void BackOption()
    {
        selectedSkin = selectedSkin - 1;
        if (selectedSkin < 0)
        {
            selectedSkin = skins.Count -1;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/selectedskin.prefab");
        SceneManager.LoadScene("GamePlay");
    }
}
*/