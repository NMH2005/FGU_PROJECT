using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1_Bar : MonoBehaviour
{
    
    public Animator mainAnimator;
    public Animator wifeAnimator;
    public Animator gangsterAnimator;

    public AudioSource jazzMusic;
    public AudioSource glassSound;
    public AudioSource dialogueSound;

    public float speed = 1.5f;
    private float timer = 0f;

    void Start()
    {
        jazzMusic.Play(); // Nhạc bar nền
    }

    void Update()
    {
        timer += Time.deltaTime;

        // 0–3s: Main lau ly, quán yên ả
        if (timer < 3f)
        {
            mainAnimator.Play("Idle_CleanGlass");
        }

        // 3–6s: Gangster gọi rượu, thái độ say
        else if (timer >= 3f && timer < 6f)
        {
            gangsterAnimator.Play("CallLoud");
            PlayDialogue("Phục vụ bar! Rót thêm ly rượu nữa!");
        }

        // 6–9s: Main nhẫn nhịn đáp
        else if (timer >= 6f && timer < 9f)
        {
            mainAnimator.Play("Talk_Calm");
            PlayDialogue("Tôi thấy anh say rồi. Để tôi mang ly nước lọc cho anh trước.");
        }

        // 9–12s: Gangster nổi cáu
        else if (timer >= 9f && timer < 12f)
        {
            gangsterAnimator.Play("AngryHitTable");
            glassSound.Play();
            PlayDialogue("Tao nói là rượu, mày không hiểu tiếng người à?");
        }

        // 12–16s: Vợ bước vào
        else if (timer >= 12f && timer < 16f)
        {
            wifeAnimator.Play("Enter");
            PlayDialogue("Em sợ anh chưa ăn gì, nên nấu ít cơm mang qua.");
        }

        // 16–20s: Main lo lắng, nói nhỏ
        else if (timer >= 16f && timer < 20f)
        {
            mainAnimator.Play("Talk_Serious");
            PlayDialogue("Anh đã nhắc em rồi… đừng đến chỗ anh làm mà. Ở đây không tiện đâu.");
        }

        // 20–25s: Gangster để ý vợ, trêu chọc
        else if (timer >= 20f && timer < 25f)
        {
            gangsterAnimator.Play("LookAtWife");
            PlayDialogue("Ồ… hóa ra vợ anh phục vụ đây à? Xinh đấy chứ…");
        }

        // 25–30s: Căng thẳng – lời qua tiếng lại
        else if (timer >= 25f && timer < 30f)
        {
            mainAnimator.Play("Defend");
            gangsterAnimator.Play("Taunt");
            PlayDialogue("Anh bạn, tôi nghĩ anh nên ngồi lại chỗ cũ.");
        }

        // 30–33s: Gangster nhếch môi, láo xược
        else if (timer >= 30f && timer < 33f)
        {
            gangsterAnimator.Play("LaughMocking");
            PlayDialogue("Mày nghĩ mày là ai mà lên mặt với tao?");
        }

        // 33–36s: Kết – Căng thẳng, im lặng
        else if (timer >= 33f && timer < 36f)
        {
            jazzMusic.volume = Mathf.Lerp(jazzMusic.volume, 0.2f, Time.deltaTime);
            mainAnimator.Play("Idle_Tense");
            wifeAnimator.Play("StepBack");
        }
    }

    void PlayDialogue(string text)
    {
        Debug.Log("[Dialogue] " + text);
        // Có thể thay bằng audio clip voice sau
    }
}
