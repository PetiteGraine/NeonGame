using UnityEngine;

public class PlayerAppearance : MonoBehaviour
{
  [SerializeField] SpriteRenderer spriteRenderer;
  [SerializeField] TrailRenderer trailRenderer;
  void Start()
  {
    spriteRenderer.sprite = PlayerSkinMenu.playerShape;
    spriteRenderer.color = PlayerSkinMenu.playerSkinColor;
    trailRenderer.startColor = PlayerSkinMenu.playerSkinColor;
    trailRenderer.endColor = PlayerSkinMenu.playerSkinColor;
    Color32 trailEndColor = PlayerSkinMenu.playerSkinColor;
    trailEndColor.a = 50;
    trailRenderer.endColor = trailEndColor;

    if (PlayerSkinMenu.playerShape == null) spriteRenderer.sprite = Resources.Load<Sprite>("RoundSkin");
  }
}
