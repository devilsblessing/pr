using System;

class CaesarCipher
{
    private int shift;

    public CaesarCipher(int shift)
    {
        this.shift = shift;
    }

    public string Encrypt(string plainText)
    {
        char[] characters = plainText.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLetter(characters[i]))
            {
                char baseChar = char.IsUpper(characters[i]) ? 'A' : 'a';
                characters[i] = (char)((characters[i] - baseChar + shift) % 26 + baseChar);
            }
        }

        return new string(characters);
    }

    public string Decrypt(string cipherText)
    {       
        shift = -shift;
        return Encrypt(cipherText);
    }
}

class pr2_zadanie3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текст для шифрования:");

        string inputText = Console.ReadLine();
        Console.WriteLine("Введите сдвиг:");
        int shift = Convert.ToInt32(Console.ReadLine());

        CaesarCipher cipher = new CaesarCipher(shift);

        string encryptedText = cipher.Encrypt(inputText);
        Console.WriteLine($"Зашифрованный текст: {encryptedText}");

        string decryptedText = cipher.Decrypt(encryptedText);
        Console.WriteLine($"Расшифрованный текст: {decryptedText}");
    }
}