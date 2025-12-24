using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LLMChatBot.Bot
{
    public class BotEngine
    {
        private readonly List<(string[] keywords, string answer)> _qa =
            new List<(string[], string)>
        {
            (new[] {"merhaba", "selam", "hey"}, "Merhaba 🙂 Sana nasıl yardımcı olabilirim?"),
            (new[] {"nasılsın", "naber", "iyi misin"}, "İyiyim 🙂 Sen nasılsın?"),
            (new[] {"adın ne", "ismin ne"}, "Ben internetsiz çalışan basit bir sohbet botuyum 🤖"),
            (new[] {"ders", "ödev"}, "Ödevlerle ilgili basit sorulara yardımcı olabilirim."),
            (new[] {"teşekkür", "sağol", "sağ ol"}, "Rica ederim 🙂"),
            (new[] {"görüşürüz", "bye"}, "Görüşürüz 👋")
        };

        private readonly string[] _fallback =
        {
            "Bunu tam anlayamadım 😅",
            "Biraz daha farklı sorar mısın?",
            "Bu konuda bilgim yok ama öğrenmek isterdim 🙂"
        };

        public string GetReply(string userText)
        {
            if (string.IsNullOrWhiteSpace(userText))
                return "Bir şey yazmadın gibi görünüyor 🙂";

            string text = Normalize(userText);

            foreach (var item in _qa)
            {
                if (item.keywords.Any(k => text.Contains(Normalize(k))))
                    return item.answer;
            }

            return _fallback[new Random().Next(_fallback.Length)];
        }

        private string Normalize(string s)
        {
            s = s.ToLowerInvariant();
            s = Regex.Replace(s, @"[^\w\sçğıöşü]", "");
            s = Regex.Replace(s, @"\s+", " ");
            return s.Trim();
        }
    }
}
