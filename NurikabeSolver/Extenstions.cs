using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurikabeSolver
{
    public static class Extensions
    {
        public static string ToPrologList(this int[] array)
        {
            var builder = new StringBuilder();
            builder.Append("[");
            builder.Append(string.Join(",", array));
            builder.Append("]");
            return builder.ToString();
        }

        public static int[] FromPrologList(this string list)
        {
            return list
                    .Replace("[", "")
                    .Replace("]", "")
                    .Split(',')
                    .Select(x => int.Parse(x))
                    .ToArray();
        }


        public static void SetValue(this DataGridViewCell cell, int value)
        {
            cell.Value = value;
        }

        public static void SetColor(this DataGridViewCell cell, Color color)
        {
            cell.Style.BackColor = color;
            cell.Style.SelectionBackColor = color;
        }

        public static object GetValue(this DataGridViewCell cell)
        {
            return cell.Value;
        }

        public static Color GetColor(this DataGridViewCell cell)
        {
            return cell.Style.BackColor;
        }

        public static bool IsEmpty(this DataGridViewCell cell)
        {
            return cell.Value == null;
        }
    }
}
