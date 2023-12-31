using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ReloadPhotos : MonoBehaviour {
    [SerializeField] private Image[] Save2DSlots;
    [SerializeField] private Image[] Save3DSlots;

    [SerializeField] private Image[] Palettes;

    private void Start() {ReloadAllPhotos();}
    
    public void ReloadPhoto3D(int SlotNumber) {
        Texture2D tex = new Texture2D(10, 10);
        tex.LoadImage(File.ReadAllBytes(Application.dataPath + $"/Resources/Image{SlotNumber}.png"));
        Sprite sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),Vector2.zero);
        Save3DSlots[SlotNumber].sprite = sprite;
    }
    
    public void ReloadPhoto2D(int SlotNumber) {
        Texture2D tex = new Texture2D(10, 10);
        tex.LoadImage(File.ReadAllBytes(Application.dataPath + $"/Resources/Image{SlotNumber}of2D.png"));
        Sprite sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height),Vector2.zero);
        sprite.texture.filterMode = FilterMode.Point;
        Save2DSlots[SlotNumber].sprite = sprite;
        //load pic
        Texture2D texPalette = new Texture2D(5, 1);
        texPalette.LoadImage(File.ReadAllBytes(Application.dataPath + $"/Resources/Palette{SlotNumber}.png"));
        sprite = Sprite.Create(texPalette, new Rect(0, 0, texPalette.width, texPalette.height),Vector2.zero);
        sprite.texture.filterMode = FilterMode.Point;
        Palettes[SlotNumber].sprite = sprite;
        //load palette
    }

    public void ReloadAllPhotos() {
        for (int SlotNumber = 0; SlotNumber < 4; SlotNumber++) {
            ReloadPhoto3D(SlotNumber);
            ReloadPhoto2D(SlotNumber);
        }
    }
}