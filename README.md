# LLMChatBot
# LLMChatBot (Offline WinForms Chatbot)

Bu proje, **C# WinForms (.NET Framework 4.8)** kullanılarak geliştirilmiş,
**offline (internetsiz) çalışan** bir masaüstü sohbet botudur.

Proje, büyük dil modellerinin (LLM) temel çalışma mantığını
**basitleştirilmiş ve yerel** bir yapı ile simüle etmektedir.

---

## 🎯 Projenin Amacı

Bu çalışmanın amacı:
- Chatbot mantığını anlamak
- Masaüstü uygulamalarda kullanıcı–bot etkileşimi kurmak
- İnternet veya harici API kullanmadan doğal dil işleme yaklaşımı uygulamaktır

---

## ✨ Özellikler

- İnternetsiz çalışma (offline)
- Anahtar kelime tabanlı cevap sistemi
- Metin normalizasyonu (küçük harf, noktalama temizleme)
- Varsayılan (fallback) cevaplar
- Modüler yapı (BotEngine ayrı sınıf)
- WinForms kullanıcı arayüzü

---

## 🛠 Kullanılan Teknolojiler

- C#
- Windows Forms
- .NET Framework 4.8

---

## 🧠 Çalışma Mantığı

1. Kullanıcı mesajı alınır  
2. Metin normalize edilir  
3. Anahtar kelimelerle eşleştirme yapılır  
4. Uygun cevap bulunursa gösterilir  
5. Eşleşme yoksa varsayılan cevap döndürülür  

---

## ▶️ Çalıştırma

1. Projeyi Visual Studio’da açın  
2. **Form1.cs** başlangıç formu olarak ayarlanıdır  
3. **F5** tuşuna basarak çalıştırın  

---

## 🎓 Akademik Not

Bu proje, **gerçek bir büyük dil modeli (LLM)** kullanmamaktadır.
Ancak LLM tabanlı sohbet sistemlerinin temel mantığını
öğretici ve sade bir şekilde göstermeyi amaçlamaktadır.

---

## 👩‍💻 Geliştirici

Bu proje bir **ders ödevi** kapsamında geliştirilmiştir.
