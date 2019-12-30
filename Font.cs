/*
    Copyright (C) 2019 Antoine Guilbaud (IronPowerTga)
   Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:
  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow
{
    public class Font
    {
        Dictionary<char, FontCharData> charDatas;

        public Font(BMFont font, Texture2D textureFont)
        {
            charDatas = new Dictionary<char, FontCharData>();

            FontCharData data;
            for (int i = 0; i < font.Chars.Length; i++)
            {
                data = new FontCharData(new Point(font.Chars[i].XOffset, font.Chars[i].YOffset), font.Chars[i].XAdvance, new Rectangle(font.Chars[i].X, font.Chars[i].Y, font.Chars[i].Width, font.Chars[i].Height));

                charDatas.Add((char)font.Chars[i].Id, data);
            }
            Texture = textureFont;
        }

        public int CharNumber => charDatas.Count;
        public FontCharData CharData(char key) => charDatas[key];

        public bool ContainsChar(char key) => charDatas.ContainsKey(key);

        public Texture2D Texture { get; }

    }
}
