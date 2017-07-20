namespace _03.ParseTags
{
    using System;

    public class ParseTags
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            var startIndex = inputText.IndexOf(openTag);

            while (startIndex != -1)
            {
                var endIndex = inputText.IndexOf(closeTag);

                if (endIndex == -1)
                {
                    break;
                }

                var toBeReplaced = inputText.Substring(startIndex, endIndex + closeTag.Length - startIndex);

                var replaced = toBeReplaced.Replace(openTag, string.Empty).Replace(closeTag, String.Empty).ToUpper();

                inputText = inputText.Replace(toBeReplaced, replaced);

                startIndex = inputText.IndexOf(openTag);
            }

            Console.WriteLine(inputText);
        }
    }
}
