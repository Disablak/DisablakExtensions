using System;
using UnityEngine;


namespace DisablakExtensions
{

    public static class StringExtensions
    {
        public static string ChangeColor(this string text, Color color)
            => $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}>{text}</color>";

        public static string MakeBold(this string text)
            => $"<b>{text}</b>";

        public static string Strikethrough(this string text)
            => $"<s>{text}</s>";

        public static string Underline(this string text)
            => $"<u>{text}</u>";

        public static string ChangeSize(this string text, int percent_text_size)
            => $"<size={percent_text_size}%>{text}";

        public static string FloatPercent(this float percent)
            => $"{percent * 100.0f}%";

        public static string FormatMinusPlus(this int value)
            => value > 0 ? $"+{value}" : $"{value}";

        public static string Align(this string text, TextAlignment align)
        {
            switch (align)
            {
            case TextAlignment.Right:  return $"<align=\"right\">{text}</align>";
            case TextAlignment.Center: return $"<align=\"center\">{text}</align>";
            case TextAlignment.Left:   return $"<align=\"left\">{text}</align>";

            default: throw new ArgumentException();
            }
        }
    }

}