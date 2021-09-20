using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EncryptionTest
{
    class CryptionClass
    {
        /// <summary>
        /// 文字列をAESで暗号化
        /// </summary>
        /// <param name="text">暗号化したい文字列</param>
        /// <returns>Base64形式で暗号化された文字列</returns>
        public string Encrypt(string text)
        {
            // 初期化ベクトル            ----- (4)
            byte[] AesIV = {0x00, 0x10, 0x20, 0x30, 0x40, 0x50, 0x60, 0x70, 0x80, 0x90, 0xA0, 0xB0, 0xC0, 0xD0, 0xE0, 0xF0 };
            // 暗号化鍵
            byte[] AesKey = {0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };

            // 暗号化方式はAES           ----- (1)
            AesManaged aes = new AesManaged();
            // 鍵の長さ                  ----- (2)
            aes.KeySize = 128;
            // ブロックサイズ（何文字単位で処理するか）
            aes.BlockSize = 128;
            // 暗号利用モード             ----- (3)
            aes.Mode = CipherMode.ECB;
            aes.IV = AesIV;
            aes.Key = AesKey;
            // パディング                 ----- (5)
            aes.Padding = PaddingMode.PKCS7;

            // 暗号化するためにはバイトの配列に変換する必要がある
            byte[] byteText = Encoding.UTF8.GetBytes(text);

            // 暗号化
            byte[] encryptText = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);

            // Base64形式（64種類の英数字で表現）で返す
            return Convert.ToBase64String(encryptText);
        }
    }
}
