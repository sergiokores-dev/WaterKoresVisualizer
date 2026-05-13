using System;
using System.Collections.Generic;
using System.Text;

namespace WaterKoresVisualizer
{




    public static class ArduinoExporter
    {

        // ============================================
        // EXPORTA MATRIZ PARA CÓDIGO ARDUINO
        // ============================================

        public static string Export(byte[][] image)
        {
            StringBuilder sb =
                new StringBuilder();

            sb.AppendLine("const byte image[][5] = {");
            sb.AppendLine();

            // percorre linhas
            for (int y = 0; y < image.Length; y++)
            {
                sb.Append("    {");

                // percorre bytes
                for (int x = 0; x < 5; x++)
                {
                    byte value = image[y][x];

                    // converte para binário
                    string binary =
                        Convert.ToString(value, 2)
                        .PadLeft(8, '0');

                    sb.Append("0b");
                    sb.Append(binary);

                    // vírgula entre bytes
                    if (x < 4)
                        sb.Append(",");
                }

                sb.Append("}");

                // vírgula entre linhas
                if (y < image.Length - 1)
                    sb.Append(",");

                sb.AppendLine();
            }

            sb.AppendLine();
            sb.AppendLine("};");

            return sb.ToString();
        }
    }
}
